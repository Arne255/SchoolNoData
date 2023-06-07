using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class LateExport
    {
        public string LateID { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam  { get; set; }
        public string Klas  { get; set; }
        public string Graad  { get; set; }
        public string Gemeente  { get; set; }
        public string Reden  { get; set; }
        public string AndereReden  { get; set; }
        public string IsGeldig  { get; set; }
        public string Tijd  { get; set; }
        public string Datum  { get; set; }

        public LateExport(string lateID, string voornaam, string achternaam, string klas, string graad, string gemeente, string reden, string andereReden, string isGeldig, string tijd, string datum)
        {
            LateID = lateID;
            Voornaam = voornaam;
            Achternaam = achternaam;
            Klas = klas;
            Graad = graad;
            Gemeente = gemeente;
            Reden = reden;
            AndereReden = andereReden;
            IsGeldig = isGeldig;
            Tijd = tijd;
            Datum = datum;
        }
    }
}
