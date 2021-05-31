using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using QRCheck.Properties;
namespace QRCheck
{
    public partial class MainForm : Form
    {



        GlobalData GD = new GlobalData();
        PatternObj PtrObj;
        public ScanObj ScObj;
        public string PathXML = Settings.Default["PathD"].ToString();
        public string PathTestFile = "";
        List<string> TestList;
        public string DbFileName = "DataList.xml";
        SetiForm SetinForm;
        Logic Lg = new Logic(Settings.Default["PathD"].ToString());
        FileInfo fileDT = new FileInfo(Settings.Default["PathD"].ToString());
        bool FileNotFoundExceptionStatus = false;
        bool FileIsnOK = true;
        string StatusStr = "";
        int TotalQant = 0;
        int OkTest = 0;
        int AutoCheckCounter = 0;
        public MainForm()
        {
            InitializeComponent();
            panelAutoCheck.Visible = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                FocusAndSelectTextBox();
                if (File.Exists(PathXML))
                {
                    GD = Lg.DEserialXML();

                    if (GD.TimeOfModified != fileDT.LastWriteTime)
                    {
                        if (Lg.CheckFileDB(GD.patternObjList))
                        {
                            MessageBox.Show("Файл Шаблонів було модифіковано стороннім Програмним забезпеченням\nДата Модифікації: " + fileDT.LastWriteTime.ToString(), "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            GD.ValidModify = false;

                        }
                        else
                        {
                            MessageBox.Show("Файл Шаблонів пошкоджено: " + fileDT.LastWriteTime.ToString(), "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            FileIsnOK = false;
                        }

                    }
                    FileNotFoundExceptionStatus = true;
                }
                else
                {
                    Lg.serialXML(GD, "Empty_DataList.xml");

                    if (DialogResult.OK == MessageBox.Show("Файл параметрів не знайдено", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning))
                    {
                        PointPath();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдається отримати доступ до файла\nІнфо:" + ex.Message, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Lg.Loging();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Не вдається отримати доступ до файла\nІнфо:" + ex.Message, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void textBoxScanData_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter && FileNotFoundExceptionStatus)
            {
                ClearLabelInfo();


                if (textBoxScanData.Text == "EDIT STRING")
                {
                    SetinForm = new SetiForm(Lg);
                    SetinForm.Show();
                    textBoxScanData.Text = "";
                    labelStatus.BackColor = Color.DimGray;
                }
                else if (Lg.IfValidStr(ref StatusStr, textBoxScanData.Text) && FileIsnOK)
                {
                    string Uniq = "no Uniq";
                    if (Lg.IfHavePattern(ref StatusStr, textBoxScanData.Text, GD.patternObjList, out PtrObj))
                    {
                        ScObj = new ScanObj(textBoxScanData.Text);
                        if (ScObj.Status && ScObj.CheckSum)
                        {
                            PutInfo(ScObj, DrawLabls(PtrObj, ScObj, panel2, panel1));

                            Uniq = ScObj.UniqNum;



                        }
                        else
                        {
                            StatusStr = ScObj.Description;
                        }
                    }
                    // Lg.Logs.Add($"\nTimeCheck:     {DateTime.Now}\nString:        {textBoxScanData.Text}\nUniq:          {Uniq}\nInfo:          {StatusStr}\nMachine name:  {Environment.MachineName} User name: {Environment.UserName}\n{new string('-', 80)}");
                    Lg.Logs.Add($"TimeCheck: {DateTime.Now} | Machine name: {Environment.MachineName} | User name: {Environment.UserName} | String: {textBoxScanData.Text} | Uniq: {Uniq} | Info: {StatusStr.Replace('\n', ' ')} ");
                    TotalQant++;
                }
                if (!FileIsnOK)
                {
                    StatusStr = "Файл Шаблонів пошкоджено: " + fileDT.LastWriteTime.ToString();
                    labelStatus.BackColor = Color.Firebrick;
                }
                FocusAndSelectTextBox();
            }
            else if (e.KeyCode == Keys.Enter && !FileNotFoundExceptionStatus)
            {
                MessageBox.Show("Не вдається отримати доступ до файла\nІнфо:", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StatusStr = "Файл параметрів не знайдено";
            }




        }
        private void FocusAndSelectTextBox()
        {
            textBoxScanData.Focus();
            textBoxScanData.SelectAll();
            labelStatus.Text = StatusStr;
            labelInfoText.Text = $" Інфо:  Перевірено елементів- {TotalQant}.   OK- {OkTest}   nOK- {TotalQant - OkTest}";


        }


        private void ClearLabelInfo()
        {
            StatusStr = "";
            labelStatus.Text = "";
            labelStatus.BackColor = Color.Firebrick;
            labelTailNumberData.Text = "";
            labelSerialNumData.Text = "";
            labelBaoData.Text = "";
            labelTimeTestData.Text = "";
            labelUniqNumData.Text = "";
            panel2.Controls.Clear();
            panel1.Controls.Clear();

        }
        private void PutInfo(ScanObj scanO, bool Stat)
        {
            labelTailNumberData.Text = scanO.TailyNum;
            labelSerialNumData.Text = scanO.SerialNum;
            labelBaoData.Text = scanO.BAONum;
            labelTimeTestData.Text = scanO.DateTestingStr;
            labelUniqNumData.Text = scanO.UniqNum != "no Uniq" ? scanO.UniqNum : "";
            if (Stat)
            {
                StatusStr = "OK";
                labelStatus.BackColor = Color.DarkGreen;
                OkTest++;
            }
            else
            {

                labelStatus.BackColor = Color.Firebrick;
            }

        }


        private void шляхФайлаШаблонівToolStripMenuItem_Click(object sender, EventArgs e)
        {


            PointPath();


        }

        void PointPath()
        {
            openFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            DialogResult resultStat = openFileDialog1.ShowDialog();

            if (resultStat == DialogResult.OK)
            {
                PathXML = openFileDialog1.FileName;
                Settings.Default["PathD"] = PathXML;
                Settings.Default.Save();
                Application.Restart();

            }

        }





        public bool DrawLabls(PatternObj patternObj, ScanObj scanObj, Panel panelScan, Panel panelPat)
        {
            string tempStr = "";
            if (scanObj.UniqNum != "no Uniq" && patternObj.PatStr.Length == 51 || patternObj.PatStr.Length == 53)
            {
                //#36A971093D    ##506866562#01022105*911 SUV3700000J*=
                tempStr = patternObj.PatStr.Substring(0, 41) + "НННННННВ*=";

            }
            else if (scanObj.UniqNum != "no Uniq" && patternObj.PatStr.Length == 42)
            {
                //#36A971093D    ##506866562#01022105*911 SUV3700000J*=
                tempStr = "ННННННН" + patternObj.PatStr.Substring(7, patternObj.PatStr.Length - 7);

            }
            else if (scanObj.UniqNum != "no Uniq" && patternObj.PatStr.Length == 58 || patternObj.PatStr.Length == 60)
            {
                //  906# 3Q0 971 013 D    ##506866562#200321*906 SUV52226850*=
                tempStr = patternObj.PatStr.Substring(0, 48) + "НННННННВ*=";
            }
            else
            {
                tempStr = patternObj.PatStr;
            }

            bool st = true;
            Point XY = new Point(20, 10);
            char[] patArr = tempStr.ToCharArray();
            char[] scanArr = scanObj.ScStr.ToCharArray();
            Label PatLb;
            Label ScanLb;
            for (int i = 0; i < patArr.Length; i++)
            {
                PatLb = DrawLbl(XY, patArr[i]);
                panelPat.Controls.Add(PatLb);
                ScanLb = DrawLbl(XY, scanArr[i]);
                ScanLb.BackColor = Lg.CheckStr(ref StatusStr, patArr[i], scanArr[i]) ? Color.White : Color.Red;
                if (Lg.CheckStr(ref StatusStr, patArr[i], scanArr[i]))
                {
                    ScanLb.BackColor = Color.White;
                }
                else
                {
                    ScanLb.BackColor = Color.Red;
                    st = false;
                }
                panelScan.Controls.Add(ScanLb);
                XY.X += (PatLb.Size.Width + 5);
            }

            return st;
        }
        public bool DrawLabls(PatternObj patternObj, ScanObj scanObj)
        {
            string tempStr = "";
            if (scanObj.UniqNum != "no Uniq" && patternObj.PatStr.Length == 51 || patternObj.PatStr.Length == 53)
            {
                //#36A971093D    ##506866562#01022105*911 SUV3700000J*=
                tempStr = patternObj.PatStr.Substring(0, 41) + "НННННННВ*=";

            }
            else if (scanObj.UniqNum != "no Uniq" && patternObj.PatStr.Length == 42)
            {
                //#36A971093D    ##506866562#01022105*911 SUV3700000J*=
                tempStr = "ННННННН" + patternObj.PatStr.Substring(7, patternObj.PatStr.Length - 7);

            }
            else if (scanObj.UniqNum != "no Uniq" && patternObj.PatStr.Length == 58 || patternObj.PatStr.Length == 60)
            {
                //  906# 3Q0 971 013 D    ##506866562#200321*906 SUV52226850*=
                tempStr = patternObj.PatStr.Substring(0, 48) + "НННННННВ*=";
            }
            else
            {
                tempStr = patternObj.PatStr;
            }

            bool st = true;
            char[] patArr = tempStr.ToCharArray();
            char[] scanArr = scanObj.ScStr.ToCharArray();
            for (int i = 0; i < patArr.Length; i++)
            {

                if (!Lg.CheckStr(ref StatusStr, patArr[i], scanArr[i]))
                {
                    st = false;
                }

            }

            return st;
        }

        Label DrawLbl(Point xy, char ch)
        {
            float x = this.Width * 0.009f;
            Label lb = new Label();
            lb.Location = xy;
            lb.AutoSize = true;
            lb.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            lb.BackColor = System.Drawing.Color.White;
            lb.Font = new System.Drawing.Font("Microsoft Sans Serif", x, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lb.Text = ch.ToString();
            return lb;
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            float xTbox = (this.Width + this.Height) * 0.013f;
            float xLbl = (this.Width + this.Height) * 0.017f;

            textBoxScanData.Font = new System.Drawing.Font("Microsoft Sans Serif", xTbox, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", xLbl, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

        }

        private void labelStatus_BackColorChanged(object sender, EventArgs e)
        {
            labelResultCheckTxt.BackColor = labelStatus.BackColor;
        }
        //AUTO//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void увымкнутиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] TempArr;
            string Result = "";
            openFileDialog2.Filter = "txt files (*.txt)|*.txt";
            DialogResult resultStat = openFileDialog2.ShowDialog();
            try
            {
                if (resultStat == DialogResult.OK)
                {
                    PathTestFile = openFileDialog2.FileName;
                    TestList = new List<string>();

                    TempArr = File.ReadAllLines(PathTestFile);
                    for (int i = 0; i < TempArr.Length; i++)
                    {
                        if (TempArr[i] != "" && TempArr[i] != null && TempArr[i].Length <= 60 && TempArr[i].Length >= 42 && Lg.IfValidStr(ref Result, TempArr[i]))
                        {
                            TestList.Add(TempArr[i]);
                        }
                    }
                    if (TestList.Count <= 0)
                    {
                        throw new Exception(" Файл не містить відповідних данних!");
                    }
                    else
                    {
                        panelAutoCheck.Visible = true;
                        labelPathAutoCheckData.Text = $"Файл: {PathTestFile} | Елементів {TestList.Count}";
                        progressBarCheck.Maximum = TestList.Count;
                        AutoCheckCounter = 0;
                        progressBarCheck.Value = 0;
                        TotalQant = 0;
                        OkTest = 0;
                        buttonSTART.Enabled = true;
                        button1.Enabled = true;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Інфо:" + ex.Message, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panelAutoCheck.Visible = false;
            }
        }





        private void buttonSTART_Click(object sender, EventArgs e)
        {
            buttonSTART.Enabled = false;
            button1.Enabled = true;
            progressBarCheck.Value++;
            if (checkBox1.Checked)
            {
                ClearLabelInfo();
                textBoxScanData.Text = "Auto mode";
                for (int i = 0; i < TestList.Count; i++)
                {



                    TotalQant++;
                    progressBarCheck.Value = progressBarCheck.Value == progressBarCheck.Maximum ? progressBarCheck.Value : progressBarCheck.Value + 1;
                    string Uniq = "no Uniq";
                    if (Lg.IfHavePattern(ref StatusStr, TestList[i], GD.patternObjList, out PtrObj))
                    {

                        ScObj = new ScanObj(TestList[i]);
                        char[] patArr = PtrObj.PatStr.ToCharArray();
                        char[] scanArr = ScObj.ScStr.ToCharArray();
                        if (ScObj.Status && ScObj.CheckSum)
                        {

                            if (DrawLabls(PtrObj, ScObj))
                            {

                                Uniq = ScObj.UniqNum;
                                OkTest++;
                                StatusStr = "OK";

                            }
                            else
                            {
                                StatusStr = "Данні не відповідають вимогам KM_Lists";

                            }




                        }
                        else
                        {
                            StatusStr = ScObj.Description;
                        }
                    }


                    Lg.Logs.Add($"TimeCheck: {DateTime.Now} | Machine name: {Environment.MachineName} | User name: {Environment.UserName} | String: {TestList[i]} | Uniq: {Uniq} | Info: {StatusStr.Replace('\n', ' ')} ");
                }
                labelInfoText.Text = $" Інфо:  Перевірено елементів- {TotalQant}.   OK- {OkTest}   nOK- {TotalQant - OkTest}";
                EndAutoCheck();


            }
            else
            {
                int delayTimer = 1000;
                if (int.TryParse(textBoxAutoTimeout.Text, out int tempTimer))
                {
                    delayTimer = tempTimer * 1000;
                }
                textBoxAutoTimeout.Text = (delayTimer / 1000).ToString();
                timerCheck.Interval = delayTimer;
                timerCheck.Enabled = true;

            }
        }


        private void timerCheck_Tick(object sender, EventArgs e)
        {



            AutoCheck(AutoCheckCounter);


            if (AutoCheckCounter == (TestList.Count - 1))
            {
                timerCheck.Enabled = false;
                EndAutoCheck();
            }
            else
            {

                AutoCheckCounter++;
            }
        }

        public void AutoCheck(int counter)
        {
            ClearLabelInfo();

            TotalQant++;
            progressBarCheck.Value = progressBarCheck.Value == progressBarCheck.Maximum ? progressBarCheck.Value : progressBarCheck.Value + 1;
            textBoxScanData.Text = TestList[counter];
            string Uniq = "no Uniq";
            if (Lg.IfHavePattern(ref StatusStr, TestList[counter], GD.patternObjList, out PtrObj))
            {

                ScObj = new ScanObj(TestList[counter]);
                if (ScObj.Status && ScObj.CheckSum)
                {
                    PutInfo(ScObj, DrawLabls(PtrObj, ScObj, panel2, panel1));

                    Uniq = ScObj.UniqNum;



                }
                else
                {
                    StatusStr = ScObj.Description;
                }
            }
            labelStatus.Text = StatusStr;
            labelInfoText.Text = $" Інфо:  Перевірено елементів- {TotalQant}.   OK- {OkTest}   nOK- {TotalQant - OkTest}";
            Lg.Logs.Add($"TimeCheck: {DateTime.Now} | Machine name: {Environment.MachineName} | User name: {Environment.UserName} | String: {textBoxScanData.Text} | Uniq: {Uniq} | Info: {StatusStr.Replace('\n', ' ')} ");



        }
        public void EndAutoCheck()
        {
            timerCheck.Enabled = false;
            labelStatus.BackColor = Color.DarkSeaGreen;

            if (Lg.Logs.Count > 0 && DialogResult.OK == MessageBox.Show($"Перевірку завершено \nРезультат: OK- {OkTest}   nOK- {TotalQant - OkTest} \nЗа потреби вкажіть місце збереження для файлу статистики.", "Інфо", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
            {

                saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.FileName = $"Auto_Check_Log_{DateTime.Now.ToString("yyyyMMddHHmmss")}";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(saveFileDialog1.FileName, Lg.Logs);
                }


            }
            Lg.Loging();
            panelAutoCheck.Visible = false;
            TotalQant = 0;
            OkTest = 0;
            textBoxScanData.Text = "Please scan QR...";
            ClearLabelInfo();
            labelStatus.BackColor = Color.DarkSeaGreen;
            FocusAndSelectTextBox();




        }



        private void labelExitAutoCheck_Click(object sender, EventArgs e)
        {
            EndAutoCheck();


        }
        private void panelAutoCheck_VisibleChanged(object sender, EventArgs e)
        {
            textBoxScanData.Enabled = !panelAutoCheck.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerCheck.Enabled = false;
            buttonSTART.Enabled = true;
            button1.Enabled = false;

        }

        private void інфоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string infoFileName =Path.Combine(Path.GetDirectoryName( PathXML),"Info.pdf");
            if (File.Exists(infoFileName))
            {
                Process.Start(infoFileName);

            }
            else
            {
                MessageBox.Show($"Файл інформаційної підтримки відсутній.", "Інфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            
        }
    }
}
