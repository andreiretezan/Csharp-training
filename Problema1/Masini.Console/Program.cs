using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Masini.Library;

namespace Masini.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Categorie C1 = new Categorie("berlina", 1900, 2120);
            Masina masina1 = new Masina("Audi", 5, Enums.Culori.albastru, C1, "ABC8564WX210000");  

            

           
        }
    }
}
