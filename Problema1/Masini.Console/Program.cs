using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Masini.Library;
using Masini.Library.Entitati;

namespace Masini.EXE
{
    class Program
    {
        static void Main(string[] args)
        {
            Categorie C1 = new Categorie("berlina", 1900, 1520);
            Categorie C2 = new Categorie("SUV", 2500, 1710);
            Categorie C3 = new Categorie("coupe", 1600, 1580);

            Masina masina1 = new Masina("Audi A6", 5, Enums.Culori.albastru, C1, "ABC8564WX210000");
            Masina masina2 = new Masina("Vw Passat", 5, Enums.Culori.argintiu, C1, "ABC1243KL110000");
            Masina masina3 = new Masina("Hyundai Santa Fe", 5, Enums.Culori.negru, C2, "ABC6767VO540000");
            Masina masina4 = new Masina("Opel Antara", 5, Enums.Culori.verde, C2, "ABC8461DF410000");
            Masina masina5 = new Masina("Audi TT", 3, Enums.Culori.rosu, C3, "ABC6545KJ540000");          

            //@todo: 1. GET o instanta a clasei DataManager; o instanta = toate !!!
            DataManager manager = null;

            //@todo: 2. adauga niste masini; !!! sa fie din toate nu doar clasa de Baza !!!
            manager.AdaugaMasina(masina1);
            manager.AdaugaMasina(masina2);
            manager.AdaugaMasina(masina3);
            manager.AdaugaMasina(masina4);
            manager.AdaugaMasina(masina5);

            //@todo: in Program.cs implementeza un fel de meniu cu comanda de la tastatura astfel incat utilizatorul sa selecteze ce vrea sa faca  
            //si sa poata introduce date;
            // foloseste optiunile astea: 
            //1 - afiseaza toata masinile
            //2 - afiseaza toata masinile avand categoria (se va identifica prin NUME introdus de utilizator) ce posibilitati avem aici ???
            //3 - afiseaza toata masinile cu aer conditionat
            //4 - adauga masina (in functie de tipul masinii, datele se vor lua de la utilizator prin linie de comanda)
            //5 - editeaza masina (se va identifica prin ID, urmand ca apoi sa construiesti noua masina cu datele de la utilizator, dupa ce a dat ID)
            //6 - sterge masina (se va lua ID de la utilizator)
            //7 - iesire din meniu
        
            Console.ReadLine();
        }
    }
}
