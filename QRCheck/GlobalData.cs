using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRCheck
{
     [Serializable]
        public class GlobalData
        {
            public List<PatternObj> patternObjList { get; set; } 

            public DateTime TimeOfModified { get; set; }

            public string Descriptions { get; set; } 
            public bool ValidModify { get; set; } 


        }
    
}
