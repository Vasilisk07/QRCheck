using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRCheck
{
    [Serializable]
    public class PatternObj
    {
        public string PatternString { get; set; }
        public string TailyNum { get; set; }

        public string BAONum { get; set; }

        public string SerialNum { get; set; }

        public DateTime DateTesting { get; set; }

        public DateTime TimeOfCreation { get; set; }

        public string Description { get; set; }

        public bool Status { get; set; }

        public PatternObj()
        {

        }

        public PatternObj(string InnerStr)
        {
            TailyNum = GetInfo(InnerStr);
            if (TailyNum == "Invalid scan data")
            {
                Status = false;
                //  throw new ArgumentException("Invalid scan data");
            }
            PatternString = InnerStr;
            Description = "no data";
            Status = true;
            TimeOfCreation = DateTime.Now;

        }



        public PatternObj(string InnerStr, string Descript)
        {
            TailyNum = GetInfo(InnerStr);
            if (TailyNum == "Invalid scan data")
            {
                Status = false;
               // throw new ArgumentException("Invalid scan data");
            }
            PatternString = InnerStr;
            Description = Descript;
            Status = true;
            TimeOfCreation = DateTime.Now;

        }
         //#5WA971015  ##508405631#239476*907 SUV0036DG6J*=
         //jj////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        static string GetInfo(string ScanStr)
        {

            if (!ScanStr.Contains("##"))
            {
                
                return "Invalid scan data";

            }
            string resultStr = "";
            ScanStr = ScanStr.TrimStart('#');
            resultStr = ScanStr.Substring(0, ScanStr.Length - (ScanStr.Length - ScanStr.IndexOf('#')));
            resultStr = resultStr.Trim(' ');
            resultStr += " ";
            resultStr += ScanStr.Substring(ScanStr.IndexOf('#') + 2, ScanStr.Length - (ScanStr.Length - ScanStr.LastIndexOf('#')));
            resultStr += " ";
            resultStr += ScanStr.Substring(ScanStr.LastIndexOf('#'), );


            return resultStr;
        }


    }
}
