using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DA;

namespace WindowsFormsApp1.Model
{
    public class Reason
    {
        public int ReasonID { get; set; }
        public string ReasonText { get; set; }
        public bool IsCustom { get; set; }
        public bool IsValid { get; set; }

    }
}
