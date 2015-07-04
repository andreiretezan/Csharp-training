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
        public Culori culoare { get; set; }
        public Categorie categorie { get; set; }
        public string serieSasiu { get; set; }
        public enum Culori
        {
            alb,
            negru,
            gri,
            rosu,
            albastru,
            verde,
            argintiu
        }
    }
}
