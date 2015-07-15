using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Masini.Library;

namespace Masini.EXE
{
    class Program
    {
        static void Main(string[] args)
        {
            Categorie C1 = new Categorie("berlina", 1900, 1520);
            Masina masina1 = new Masina("Audi A6", 5, Enums.Culori.albastru, C1, "ABC8564WX210000");
            Masina masina2 = new Masina("Vw Passat", 5, Enums.Culori.argintiu, C1, "ABC1243KL110000");

            Categorie C2 = new Categorie("SUV", 2500, 1710);
            Masina masina3 = new Masina("Hyundai Santa Fe", 5, Enums.Culori.negru, C2,"ABC6767VO540000");
            Masina masina4 = new Masina("Opel Antara", 5, Enums.Culori.verde, C2, "ABC8461DF410000");

            Categorie C3 = new Categorie("coupe", 1600, 1580);
            Masina masina5 = new Masina("Audi TT", 3, Enums.Culori.rosu, C3, "ABC6545KJ540000");

            Console.WriteLine(masina1.ToString()); Console.WriteLine();
            Console.WriteLine(masina2.ToString()); Console.WriteLine();
            Console.WriteLine(masina3.ToString()); Console.WriteLine();
            Console.WriteLine(masina4.ToString()); Console.WriteLine();
            Console.WriteLine(masina5.ToString()); Console.WriteLine();

            Console.WriteLine("Alegeti una din urmatoarele categorii:C1, C2, C3");
            string alegere = Console.ReadLine();
            if (alegere=="C1" || alegere=="c1")
            {
                Console.WriteLine(masina1.ToString());
                Console.WriteLine(masina2.ToString());
            }
            else if (alegere=="C2" || alegere=="c2")
            {
                Console.WriteLine(masina3.ToString());
                Console.WriteLine(masina4.ToString());
            }
            else if (alegere=="C3" || alegere=="c3")
            {
                Console.WriteLine(masina5.ToString());
            }
            else
            {
                Console.WriteLine("Categoria aleasa nu exista, va rugam incercati din nou");
            }

            /*List<string> nume = new List<string>();
            nume.Add("");
            nume.Add("");
            foreach (var n in nume) 
            {
                System.Console.WriteLine(n);
            }*/

            Console.ReadLine();
        }
    }
}
