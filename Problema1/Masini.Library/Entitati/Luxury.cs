using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masini.Library.Entitati
{
    class Luxury:Masina
    {
        public string AerConditionatC { get; set; }
        public string SistemParktronic { get; set; }
        public string EntertainmentSystem { get; set; }

        public Luxury(string aer, string sistem, string enterain, string marca, int nrUsi, Enums.Culori culoare, Categorie categ, string serieSasiu)
            : base(marca, nrUsi, culoare, categ, serieSasiu)
        {
            this.AerConditionatC = aer;
            this.SistemParktronic = sistem;
            this.EntertainmentSystem = enterain;
        }
    }
}
