using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masini.Library
{
    class Premium:Masina
    {
        public string aerConditionat { get; set; }
        public string senzoriParcare { get; set; }
        public string casetofonDigitalCD { get; set; }

        public Premium (string aerC, string senzori, string casetofon, string Marca, int NrUsi, Enums.Culori Culoare, Categorie categ, string SerieSasiu)
            :base(Marca, NrUsi, Culoare, categ, SerieSasiu)
        {
            aerConditionat = aerC;
            senzoriParcare = senzori;
            casetofonDigitalCD = casetofon;
        }
    }
}
