using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Student
    {
        public string CardUID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ClassName { get; set; }
        public string TownshipNameOne { get; set; }
        public string TownshipNameTwo { get; set; }

        public string FullNameClassNameTownship
        {
            get { return Name + " " + Surname + " " + ClassName + " " + TownshipNameOne + " | " + TownshipNameTwo; }
        }
    }
}
