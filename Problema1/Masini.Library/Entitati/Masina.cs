using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masini.Library.Entitati
{
    public class Masina
    {
        //@todo: avem nevoie ca fiecare masina sa fie identificabila prin ceva unic - Id - poti folosi GUID
        //@todo: adauga Id la fiecare masina; pe constructor initializeaza Id
        //https://msdn.microsoft.com/en-us/library/system.guid.newguid(v=vs.110).aspx 

        public string Marca { get; set; }
        public int NrUsi { get; set; }
        public Enums.Culori Culoare { get; set; }
        public Categorie Categorie { get; set; }
        public string SerieSasiu { get; set; }
        
        public Masina (string marca, int nrUsi, Enums.Culori culoare, Categorie categ, string serieSasiu)
        {
            this.Marca = marca;
            this.NrUsi = nrUsi;
            this.Culoare = culoare;
            this.Categorie = categ;
            this.SerieSasiu = serieSasiu;
        }

        public override string ToString()
        {
            return string.Format("Detalii masina:\n Model: {0}, Numar usi:{1}, Culoare:{2}, Tip:{3}, Serie sasiu:{4}", 
                Marca, NrUsi, Culoare, Categorie, SerieSasiu) ;
        }
    }
}
