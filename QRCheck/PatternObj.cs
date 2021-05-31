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

        public string PatStr { get; set; }

        public string TailyNum { get; set; }

        public string Description { get; set; }

        public DateTime TimeOfCreation { get; set; }

        public bool Status { get; set; }

        public PatternObj()
        {

        }

        public PatternObj(string InnerStr)
        {
            TailyNum = GetTailyNum(InnerStr);
            if (TailyNum == "Not Valid data")
            {
                Status = false;
                PatStr = "Введені не коректні данні";
                Description = "no data";
                TimeOfCreation = DateTime.Now;

            }
            else
            {
                PatStr = InnerStr;
                Description = "no data";
                Status = true;
                TimeOfCreation = DateTime.Now;

            }


        }

        string GetTailyNum(string inStr)
        {
            // 906# 3Q0 971 013 D    ##506866562#20032111*906 SUV52226850*=
            // #5GE971531J    ##506866562#01032109*912 SUV1008733W*=
            // 1002796090221800120EDP92006AB___>________<
            string resultStr = "Not Valid data";
            if (inStr.Length == 51)
            {   // #5GE971531J    ##506866562#01032109*912 SUV1008733W*=

                inStr = inStr.TrimStart('#');
                resultStr = inStr.Substring(0, 14).TrimEnd(' ');
            }
            else if (inStr.Length == 42)
            {   // 1002796090221800120EDP92006AB___>________<

                resultStr = inStr.Substring(19,13).TrimEnd('_');
            }
            else if(inStr.Length == 58)
            {
                // 906# 3Q0 971 013 D    ##506866562#20032111*906 SUV52226850*=

                resultStr = inStr.Substring(4, 18);



            }



            return resultStr;
        }
    }
}
