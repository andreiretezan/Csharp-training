using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masini.Library
{
    class Budget : Masina
    {
        public string casetofonCD { get; set; }

        public Budget(string casetofon, string Marca, int NrUsi, Enums.Culori Culoare, Categorie categ, string SerieSasiu)
            : base(Marca, NrUsi, Culoare, categ, SerieSasiu)
        {
            casetofonCD = casetofon;
        }
    }
}
