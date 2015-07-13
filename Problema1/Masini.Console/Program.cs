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
            Masina masina1 = new Masina("Audi", 5, Enums.Culori.albastru, Categorie, "ABC8564WX210000");

            Categorie C1= new Categorie("berlina", 1900, 2120);

           /* C1.nume= "berlina";
            C1.capacitateMotor=2500;
            C1.greutate=2100;*/

            

           
        }
    }
}
