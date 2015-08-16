using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masini.Library.Entitati
{
    class Budget : Masina
    {
        public string CasetofonCD { get; set; }

        public Budget(string casetofon, string marca, int nrUsi, Enums.Culori culoare, Categorie categ, string serieSasiu)
            : base(marca, nrUsi, culoare, categ, serieSasiu)
        {
            this.CasetofonCD = casetofon;
        }
    }
}
