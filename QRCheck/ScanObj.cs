using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRCheck
{
   public class ScanObj
    {
        public string ScStr { get; }
        public string TailyNum { get; }

        public string BAONum { get; }

        public string SerialNum { get; }

        public string UniqNum { get; }

        public DateTime DateTesting { get; }
        public string DateTestingStr { get; }

        public bool Status { get; private set; }
        public  bool CheckSum { get; }

        public string Description { get; private set; }

        string Base43 = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-. $/+%";


        
        public ScanObj(string InnerStr)
        {
            if (InnerStr.Length == 53)//записуєм скановану стрічку без КВ
            {//  #5GE971531J    ##506866562#01032109*912 SUV1008733W*=
                ScStr = InnerStr.Substring(0, 33) + InnerStr.Substring(35, 18);
            }
            else if(InnerStr.Length == 60)
            { //  906# 3Q0 971 013 D    ##506866562#20032111*906 SUV52226850*=

                ScStr = InnerStr.Substring(0, 40) + InnerStr.Substring(42, 18);
            }
            else 
            {
                ScStr = InnerStr;
            }
            

            string[] infoArr = GetInfo(InnerStr).Split(' ');
        
                infoArr[0] = infoArr[0].Replace('П', ' ');
            
            if (infoArr.Length == 4)
            {
                TailyNum = infoArr[0];
                BAONum = infoArr[2];
                SerialNum = infoArr[3]; 
                DateTestingStr = infoArr[1];
                Status = true;
                CheckSum = GetСheckSum(Base43, InnerStr);
                if (!isNumber(SerialNum))
                {
                    UniqNum = DecodingUnic(Base43, SerialNum);
                    
                }
                else
                {

                    UniqNum = "no Uniq";
                }
               
                try
                {
                    DateTesting = CheckDataTest(infoArr[1]);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Status = false;
                    Description = "недійсна дата тестування\n"+ infoArr[1];
                }
            }
            else if (infoArr.Length == 3)
            {
                TailyNum = infoArr[0].TrimEnd('_'); ;
                SerialNum = infoArr[2];
                DateTestingStr = infoArr[1];
                Status = true;
                BAONum = "";
                CheckSum = true;
                if (!isNumber(SerialNum))
                {
                    UniqNum = DecodingUnic(Base43, SerialNum);

                }
                else
                {

                    UniqNum = "no Uniq";
                }
                try
                {
                    DateTesting = CheckDataTest(infoArr[1]);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Status = false;
                    Description = "недійсна дата тестування\n" + infoArr[1];
                }
            }
            else
            {
                Description = "зісканований обєкт не є дійсним";
                Status = false;
            }

            
    

        }
          
        //  906# 3Q0 971 013 D    ##506866562#20032111*906 SUV52226850*=
        //  #5WA971015  ##508405631#239476*907 SUV0036975J*=
        //  #5GE971531J    ##506866562#01032109*912 SUV1008733W*=
        //jj////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public string GetInfo(string ScanStr)
        {
            string resultStr = "";
            if (ScanStr.Length==51|| ScanStr.Length == 53)
            {
                char[] tempArr;
                
                ScanStr = ScanStr.TrimStart('#');   // 5WA971015  ##508405631#239476*907 SUV0036975J*=
                resultStr = ScanStr.Substring(0,14);
                resultStr = resultStr.Trim(' ');
                resultStr += " ";
                ScanStr = ScanStr.Remove(0, ScanStr.Length - (ScanStr.Length - ScanStr.IndexOf('#')));   // 5WA971015  ##508405631#239476*907 SUV0036975J*=
                ScanStr = ScanStr.TrimStart('#');                                                        // 508405631#239476*907 SUV0036975J*=
                ScanStr = ScanStr.Remove(0, ScanStr.Length - (ScanStr.Length - ScanStr.IndexOf('#')));
                ScanStr = ScanStr.TrimStart('#');
                tempArr = ScanStr.Substring(0, ScanStr.Length - (ScanStr.Length - ScanStr.IndexOf('*'))).ToCharArray(); // 239476*907 SUV0036975J*=  
                for (int i = 0; i < tempArr.Length; i++)
                {
                    resultStr += i != 0 && i % 2 == 0 ? "." : "";
                    resultStr += i == 6 ? "CW" : "";
                    resultStr += tempArr[i];
                }
                resultStr += " ";
                ScanStr = ScanStr.Remove(0, ScanStr.Length - (ScanStr.Length - ScanStr.IndexOf('*')));
                ScanStr = ScanStr.TrimStart('*');
                resultStr += ScanStr.Substring(0,4).Trim(' ');
                resultStr += " ";
                resultStr += ScanStr.Substring(7, 7);
                return resultStr;

            }
            else if (ScanStr.Length == 42)
            {
                char[] tempArr;

                resultStr+= ScanStr.Substring(19,13);//tail
                resultStr += " ";
                tempArr = ScanStr.Substring(7,6).ToCharArray();
                for (int i = 0; i < tempArr.Length; i++)
                {
                    resultStr += i != 0 && i % 2 == 0 ? "." : "";
                    resultStr += i == 6 ? "CW" : "";
                    resultStr += tempArr[i];//data
                }
                resultStr += " ";
                resultStr += ScanStr.Substring(0,7);//serial
            }
            else if(ScanStr.Length == 60|| ScanStr.Length == 58)
            { //  906# 3Q0 971 013 D    ##506866562#20032111*906 SUV52226850*=
                char[] tempArr;
                
                
                
                    ScanStr = ScanStr.Replace(' ','П') ;
                
                resultStr += ScanStr.Substring(4, 18);//tail
                ScanStr = ScanStr.Substring(34);
                resultStr += " ";
                tempArr = ScanStr.Substring(0, ScanStr.Length-( ScanStr.Length- (ScanStr.IndexOf('*')))).ToCharArray();
                for (int i = 0; i < tempArr.Length; i++)
                {
                    resultStr += i != 0 && i % 2 == 0 ? "." : "";
                    resultStr += i == 6 ? "CW" : "";
                    resultStr += tempArr[i];//data
                }
                resultStr += " ";
                ScanStr = ScanStr.Substring(ScanStr.IndexOf('*')+1);
                resultStr += ScanStr.Substring(0,3);//BAO
                resultStr += " ";
                resultStr += ScanStr.Substring(7,7);//serial


            }
            return resultStr;

        }

        DateTime CheckDataTest (string strData)
        {
            string[] date = strData.Split('.');
            DateTime  dateTest = new DateTime(Convert.ToInt32(date[2]) + 2000, Convert.ToInt32(date[1]), Convert.ToInt32(date[0]));
            if (dateTest > DateTime.Now)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (date.Length == 4)
            {
                date[3] = date[3].Substring(2, 2);
                int cw = CultureInfo.CurrentUICulture.Calendar.GetWeekOfYear(dateTest, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
                if (Convert.ToInt32(date[3]) != cw)
                {
                    throw new ArgumentOutOfRangeException();

                }

            }

            return dateTest;
        }


        private bool isNumber(string str)
        { //великі літери починаються з кода 65 закінчуються кодом 90. Згідно таблиці ascii "ABCDEFGHIJKLMNOPQRSTUVWXYZ"

            char[] ch = str.ToCharArray();
            bool stat = true;
            for (int i = 0; i < ch.Length; i++)
            {
                for (int j = 65; j <= 90; j++)
                {
                    if ((char)j == ch[i])
                    {
                        return false;
                    }
                }

            }

            return stat;
        }

        // #5GE971531J    ##506866562#01032109*912 SUV000QGLJW*= //1234567
        string DecodingUnic(string bAseCode,string serialNum)
        {
            

            serialNum = serialNum.TrimStart('0');
            char[] serialNumArr = serialNum.ToCharArray();
            int unicNr = bAseCode.IndexOf(serialNumArr[0]);

            for (int i = 0; i < serialNumArr.Length-1; i++)
            {
                unicNr = (unicNr * 36) + bAseCode.IndexOf(serialNumArr[i + 1]);
            }

            if (unicNr<=0|| unicNr.ToString().Length>7)
            {
                Description = "невірний Unic: " + unicNr;
                Status = false;
            }
            string Result = "000000" + unicNr.ToString();
            return Result.Substring(Result.Length-7);
        }

        bool GetСheckSum(string baseCode, string modData)
        {
            string CheckCum = modData.Substring(modData.IndexOf('*')+15,1);
            modData = modData.Substring(modData.IndexOf('*')+1, 14);
            char[] modDataArr = modData.ToCharArray();
            int sum = 0;
            bool StatCheck = false;
            for (int i = 0; i < modDataArr.Length; i++)
            {
                sum += baseCode.IndexOf(modDataArr[i]);

            }
            sum = sum % 43;
            StatCheck =  baseCode.IndexOf(CheckCum) == sum;

            if (!StatCheck)
            {
                Description = "невірно вираховується \"check sum\"\n"+"\" "+ CheckCum +" \""+" замість "+ "\" "+baseCode.Substring(sum,1)+" \"";

            }

            return StatCheck;
        }




    }
}
