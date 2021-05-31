using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QRCheck
{
    public class Logic
    {


        public string PathDb { get; }
        public List<string> Logs { get; set; }
        public string description { get; private set; }



        public Logic(string path)
        {

            PathDb = path;
            Logs = new List<string>();
            description = "";
        }


        public void serialXML(GlobalData GD)
        {
            string PathBackup = Path.Combine(Path.GetDirectoryName(PathDb), "Backup");
            FileInfo fileDT = new FileInfo(PathDb);

            if (File.Exists(PathDb))
            {

                if (!Directory.Exists(PathBackup))
                {
                    Directory.CreateDirectory(PathBackup);
                }
                if (GD.ValidModify)
                {
                    PathBackup = Path.Combine(PathBackup, DateTime.Now.ToString("yyyy_MM_dd_HHmmss_") + "BackupDataList.xml");
                }
                else
                {
                    GD.ValidModify = true;
                    PathBackup = Path.Combine(PathBackup, DateTime.Now.ToString("yyyy_MM_dd_HHmmss_") + "NotValidBackup!DataList.xml");

                }

                fileDT.CopyTo(PathBackup);
            }
            GD.TimeOfModified = DateTime.Now;
            XmlSerializer XMLSerialDT = new XmlSerializer(typeof(GlobalData));
            using (FileStream fs = new FileStream(PathDb, FileMode.Create))
            {

                XMLSerialDT.Serialize(fs, GD);

            }
            fileDT.LastWriteTime = GD.TimeOfModified;

        }
        //deserial
        public GlobalData DEserialXML()
        {
            XmlSerializer XMLSerialDT = new XmlSerializer(typeof(GlobalData));
            using (FileStream fs = new FileStream(PathDb, FileMode.Open))
            {
                return (GlobalData)XMLSerialDT.Deserialize(fs);

            }

        }
        public void serialXML(GlobalData GD, string path) 
        {

            GD.TimeOfModified = DateTime.Now;
            XmlSerializer XMLSerialDT = new XmlSerializer(typeof(GlobalData));
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                XMLSerialDT.Serialize(fs, GD);
            }
        }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public bool IfHavePattern(ref string statusStr, string ScanStr, List<PatternObj> patObgList, out PatternObj PtrObj)
        {
            PtrObj = new PatternObj();
            if (IfValidStr(ref statusStr, ScanStr))
            {
                ScanObj scanObj = new ScanObj(ScanStr);
                foreach (var item in patObgList)
                {
                    if (item.TailyNum == scanObj.TailyNum)
                    {
                        PtrObj = item;
                        return true;
                    }
                }
                statusStr = "Зісканований Tail не знайдено в бібліотеці";
            }

            return false;
        }



        public bool IfValidStr(ref string statusStr, string scanStr)
        {
            string maskSrt = "";
            char[] scanArr = scanStr.ToCharArray();
            char[] maskArr;
            switch (scanStr.Length)
            {
                case 53:
                    // #36A971093D    ##506866562#01022105*911 SUV3700000J*=
                    maskSrt = "#@@@@@@@@@@@@@@##@@@@@@@@@#@@@@@@@@*@@@@@@@@@@@@@@@*=";
                    maskArr = maskSrt.ToCharArray();

                    for (int i = 0; i < maskArr.Length; i++)
                    {
                        if (maskArr[i] == '@')
                        {
                            continue;
                        }
                        else if (maskArr[i] != scanArr[i])
                        {
                            statusStr = "Зіскановані данні не відповідають масці #......##.....#...*....*=";
                            return false;
                        }


                    }

                    break;


                case 51:
                    // #36A971093D    ##506866562#010221*911 SUV3700000J*=
                    maskSrt = "#@@@@@@@@@@@@@@##@@@@@@@@@#@@@@@@*@@@@@@@@@@@@@@@*=";
                    maskArr = maskSrt.ToCharArray();

                    for (int i = 0; i < maskArr.Length; i++)
                    {
                        if (maskArr[i] == '@')
                        {
                            continue;
                        }
                        else if (maskArr[i] != scanArr[i])
                        {
                            statusStr = "Зіскановані данні не відповідають масці #......##.....#...*....*=";
                            return false;
                        }


                    }
                    break;

                case 60:
                  //  906# 3Q0 971 013 D    ##506866562#20032111*906 SUV52226850*=
                    maskSrt = "@@@#@@@@@@@@@@@@@@@@@@##@@@@@@@@@#@@@@@@@@*@@@@@@@@@@@@@@@*=";
                    maskArr = maskSrt.ToCharArray();

                    for (int i = 0; i < maskArr.Length; i++)
                    {
                        if (maskArr[i] == '@')
                        {
                            continue;
                        }
                        else if (maskArr[i] != scanArr[i])
                        {
                            statusStr = "Зіскановані данні не відповідають масці #......##.....#...*....*=";
                            return false;
                        }


                    }
                    break;
                case 58:
                   // 906# 3Q0 971 013 D    ##506866562#200321*906 SUV52226850*=
                    maskSrt = "@@@#@@@@@@@@@@@@@@@@@@##@@@@@@@@@#@@@@@@*@@@@@@@@@@@@@@@*=";
                    maskArr = maskSrt.ToCharArray();

                    for (int i = 0; i < maskArr.Length; i++)
                    {
                        if (maskArr[i] == '@')
                        {
                            continue;
                        }
                        else if (maskArr[i] != scanArr[i])
                        {
                            statusStr = "Зіскановані данні не відповідають масці #......##.....#...*....*=";
                            return false;
                        }


                    }
                    break;

                case 42:
                    // 0002188090221800120EDP92003B____>________<
                    maskSrt = "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@>@@@@@@@@<";
                    maskArr = maskSrt.ToCharArray();

                    for (int i = 0; i < maskArr.Length; i++)
                    {
                        if (maskArr[i] == '@')
                        {
                            continue;
                        }
                        else if (maskArr[i] != scanArr[i])
                        {
                            statusStr = "Зіскановані данні не відповідають масці .........>....<";
                            return false;
                        }
                    }
                    break;


                default:
                    statusStr = "Зіскановано " + scanStr.Length + " символів, вхідні данні не співпадають по довжині";
                    return false;

            }
            return true;

        }


        private bool isNumber(char ch)
        {
            //Цифри починаються з кода 48  закінчуються кодом 57. Згідно таблиці ascii "0123456789"
            for (int i = 48; i <= 57; i++)
            {


                if ((char)i == ch)
                {
                    return true;
                }
            }
            return false;
        }

        private bool isBigLetter(char ch)
        {
            //великі літери починаються з кода 65 закінчуються кодом 90. Згідно таблиці ascii "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            for (int i = 65; i <= 90; i++)
            {


                if ((char)i == ch)
                {
                    return true;
                }
            }
            return false;
        }

        private bool isSymbol(char ch)
        {
            //символи починаються з кода 32-47 58-64 91-96 123-126 . Згідно таблиці ascii    !"#$%&'()*+,-./:;<=>?@[\]^_`
            for (int i = 32; i <= 126; i++)
            {



                if ((char)i == ch)
                {
                    return true;
                }
                switch (i)
                {
                    case 47:
                        {
                            i = 57;
                        }
                        break;

                    case 64:
                        {
                            i = 90;
                        }
                        break;

                    case 96:
                        {
                            i = 122;
                        }
                        break;
                }
            }
            return false;
        }

        public bool CheckStr(ref string StString, char PatChar, char ScanChar)
        {
            bool stat = true;
            if (PatChar == ScanChar)
            {

                stat = true;
                //  DrawLabls(ScanStrArr[i], statSum, panel2);


            }
            else if (PatChar == 'Ц' && isNumber(ScanChar))
            {

                stat = true;

            }
            else if (PatChar == 'Б' && isBigLetter(ScanChar))
            {

                stat = true;

            }
            else if (PatChar == 'С' && isSymbol(ScanChar))
            {

                stat = true;

            }
            else if (PatChar == 'Н' && (isNumber(ScanChar) || isBigLetter(ScanChar)))
            {

                stat = true;

            }
            else if (PatChar == 'В' && (((isNumber(ScanChar) || isBigLetter(ScanChar))) || isSymbol(ScanChar)))
            {
                stat = true;


            }
            else
            {
                StString = "Данні не відповідають вимогам KM_Lists";
                stat = false;

            }



            return stat;
        }


        public void Loging()
        {
            if (Logs.Count>0)
            {
                string DirectoryPathLogs = Path.Combine(Path.GetDirectoryName(PathDb), "QR_Statistic");

                if (!Directory.Exists(DirectoryPathLogs))
                {
                    Directory.CreateDirectory(DirectoryPathLogs);
                }

                File.AppendAllLines(Path.Combine(DirectoryPathLogs, DateTime.Now.ToString("MM_yyyy_") + "QRLogs.txt"), Logs);
                Logs.Clear();

            }

        }


        public bool CheckFileDB(List<PatternObj> patObgList)
        {
            string status = "";
            foreach (var item in patObgList)
            {
                if (!IfValidStr(ref status, item.PatStr))
                {
                    description = status;
                    return false;
                } 
            }
            return true;
        }



    }
}
