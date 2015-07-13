using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masini.Library
{
    public class Masina
    {
        public string marca { get; set; }
        public int nrUsi { get; set; }
        public Enums.Culori culoare { get; set; }
        public Categorie categorie { get; set; }
        public string serieSasiu { get; set; }
        
        public Masina (string Marca, int NrUsi, Enums.Culori Culoare, Categorie categ, string SerieSasiu)
        {
            marca = Marca;
            nrUsi = NrUsi;
            culoare = Culoare;
            categorie = categ;
            serieSasiu = SerieSasiu;
        }

        public override string ToString()
        {
            return string.Format("Detalii masina:\n Model: {0}, Numar usi:{1}, Culoare:{2}, Tip:{3}, Serie sasiu:{4}", 
                marca, nrUsi, culoare, categorie, serieSasiu) ;
        }
    }
}
