using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masini.Library.Entitati
{
    class Premium : Masina
    {
        public string AerConditionat { get; set; }
        public string SenzoriParcare { get; set; }
        public string CasetofonDigitalCD { get; set; }

        public Premium(string aerC, string senzori, string casetofon, string marca, int nrUsi, Enums.Culori culoare, Categorie categ, string serieSasiu)
            : base(marca, nrUsi, culoare, categ, serieSasiu)
        {
            this.AerConditionat = aerC;
            this.SenzoriParcare = senzori;
            this.CasetofonDigitalCD = casetofon;
        }
    }
}
