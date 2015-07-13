using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masini.Library
{
    class Luxury:Masina
    {
        public string AerConditionatC { get; set; }
        public string sistemParktronic { get; set; }
        public string entertainmentSystem { get; set; }

        public Luxury(string aer, string sistem, string enterain, string Marca, int NrUsi, Enums.Culori Culoare, Categorie categ, string SerieSasiu)
            : base(Marca, NrUsi, Culoare, categ, SerieSasiu )
        {
            AerConditionatC = aer;
            sistemParktronic = sistem;
            entertainmentSystem = enterain;
        }
    }
}
