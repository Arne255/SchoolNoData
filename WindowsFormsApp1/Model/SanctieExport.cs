using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class SanctieExport
    {
        public string SanctionID { get; set; }

        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Soort { get; set; }
        public string Klas { get; set; }
        public string Graad { get; set; }
        public string Datum { get; set; }

        public SanctieExport(string sanctionID, string voornaam, string achternaam, string soort, string klas, string graad, string datum)
        {
            SanctionID = sanctionID;
            Voornaam = voornaam;
            Achternaam = achternaam;
            Soort = soort;
            Klas = klas;
            Graad = graad;
            Datum = datum;
        }
    }
}
