using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Sanction
    {
        public int SanctionID { get; set; }
        public string CardUID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Soort { get; set; }
        public string ClassName { get; set; }
        public DateTime SanctionDatum { get; set; }
        public int InitLateID { get; set; }

    }
}
