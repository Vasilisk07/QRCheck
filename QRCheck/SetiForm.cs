using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCheck
{
    public partial class SetiForm : Form
    {
        string PathFile;
        Logic Lg;
        FileInfo fileDT;
        GlobalData GlobalDt;
        PatternObj ptrObj;

        public SetiForm()
        {
            InitializeComponent();
        }

        public SetiForm(Logic lg)
        {
            InitializeComponent();
            PathFile = lg.PathDb;
            Lg = lg;
        }


        private void SetiForm_Load(object sender, EventArgs e)
        {
            
            try
            {
                if (File.Exists(PathFile))
                {
                    fileDT = new FileInfo(PathFile);
                    GlobalDt = Lg.DEserialXML();
                    if (GlobalDt.TimeOfModified != fileDT.LastWriteTime)
                    {
                        if (Lg.CheckFileDB(GlobalDt.patternObjList))
                        {
                            MessageBox.Show("Файл Шаблонів було модифіковано стороннім Програмним забезпеченням\nДата Модифікації: " + fileDT.LastWriteTime.ToString(), "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            GlobalDt.ValidModify = false;
                        }
                        else
                        {
                            MessageBox.Show("Файл Шаблонів пошкоджено: " + fileDT.LastWriteTime.ToString(), "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    DrawListbox();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Не вдається отримати доступ до файла\nІнфо:" + ex.Message, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void SetiForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Lg.serialXML(GlobalDt);
                Lg.Logs.Add($"Зміна файла з шаблонами, дата зміни {DateTime.Now} Machine name: {Environment.MachineName} User name: {Environment.UserName}\n");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Не вдається отримати доступ до файла\nІнфо:" + ex.Message, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


           
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string patern51 = "";
            string patern42 = "";
            string Tail51 = "";
            string Tail42 = "";
          
            //#4M2971059AA   ##506866562#07122050*910 SUV2500003I*=
            //0002188090221800120EDP92003B____>________<
            // 906# 3Q0 971 013 D    ##506866562#20032111*906 SUV52226850*=

            if (textBox1TailNum14.Text.Length>4)
            {
                textBox4BaoNum4.Text = textBox4BaoNum4.Text.Length == 3 ? textBox4BaoNum4.Text + " " : textBox4BaoNum4.Text;
                Tail51 = textBox1TailNum14.Text.Trim(' ');
                Tail51 += new string(' ', 14-Tail51.Length);
                patern51 = $"#{Tail51}##{textBox2CodeChm9.Text}#{textBox3DateTesting6.Text}*{textBox4BaoNum4.Text}{textBox5SuvSerial11.Text}*=";
            }
            else if (textBoxABTtail_4.Text.Length>4)
            {
                Tail42 = textBoxABTtail_4.Text.TrimEnd('_');
                Tail42 += (new string('_', 13 - textBoxABTtail_4.Text.Length));
                patern42 = $"{textBoxABTserial_1.Text}{textABTdatum_2.Text}{textBoxABTCodeCHM_3.Text}{Tail42}>{textBoxABTtile2_5.Text}<";
            }

           






            if (patern51.Length==51 && !EqualTailNum(GlobalDt.patternObjList, patern51))
            {

                GlobalDt.patternObjList.Add(ptrObj = new PatternObj(patern51));
                textBox1TailNum14.Text = "";
                textBox4BaoNum4.Text = "";
                textBox5SuvSerial11.Text = "";
                Console.Beep();
                DrawListbox();

            }
            else if (patern42.Length==42 && !EqualTailNum(GlobalDt.patternObjList, patern42))
            {

                GlobalDt.patternObjList.Add(ptrObj = new PatternObj(patern42));
                textBoxABTtail_4.Text = "";
                textBoxABTserial_1.Text = "";
                Console.Beep();
                DrawListbox();
            }
            else if( textBoxD0B60Sumb.Text.Length==58)
            {
                //906# 3Q0 971 013 D    ##506866562#20032111*906 SUV52226850*=
                GlobalDt.patternObjList.Add(ptrObj = new PatternObj(textBoxD0B60Sumb.Text));
                textBoxD0B60Sumb.Text = "";
                Console.Beep();
                DrawListbox();



            }
            else
            {
               
                MessageBox.Show("Введено не коректні данні або шаблон з таким Tail вже існує", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Видалити вибраний елемент?", "Видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (listBox1.SelectedItems.Count == 1 && res == DialogResult.Yes)
            {
                GlobalDt.patternObjList.RemoveAt(listBox1.SelectedIndex);


                labelInfoPattern.Text = "Інфо:";
            }
            DrawListbox();
        }

        void DrawListbox()
        {
            listBox1.Items.Clear();
            labelInfoPattern.Text = $"Інфо: кількість шаблонів в базі = {GlobalDt.patternObjList.Count} ";
            foreach (var item in GlobalDt.patternObjList)
            {
                listBox1.Items.Add(item.PatStr);


            }

        }

        bool EqualTailNum(List<PatternObj> PatOBList, string patternStr)
        {
            
            if ( patternStr.Length == 51)
            { // #5GE971531J    ##506866562#01032109*912 SUV1008733W*=
                patternStr = patternStr.TrimStart('#');
                patternStr = patternStr.Substring(0, 14);
                patternStr = patternStr.Trim(' ');
                int i = 0;
                foreach (var item in PatOBList)
                {
                    
                    if (item.TailyNum == patternStr)
                    {
                        listBox1.SetSelected(i, true);
                        return true;
                    }
                    i++;
                }
            }
            else if (patternStr.Length == 42)
            { // 1002796090221800120EDP92006AB___>________<
                int i = 0;
                patternStr = patternStr.Substring(19, 13).TrimEnd('_');
                foreach (var item in PatOBList)
                {
                   
                    if (item.TailyNum == patternStr)
                    {
                        listBox1.SetSelected(i, true);
                        
                        return true;
                    }
                    i++;
                }

                
            }

  



            return false;
        }

        private void SetiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Restart();
        }


    }
}
