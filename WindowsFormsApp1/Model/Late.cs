using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class Late
    {
        public int LateID { get; set; }
        public string CardUID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ClassName { get; set; }
        public string TownshipNameOne { get; set; }
        public string TownshipNameTwo { get; set; }
        public int ReasonID { get; set; }
        public string ReasonText { get; set; }
        public bool ReasonIsCustom { get; set; }
        public bool ReasonIsValid { get; set; }
        public DateTime LateDate { get; set; }
    }
}
