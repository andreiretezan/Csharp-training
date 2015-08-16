using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masini.Library.Entitati
{
    public class Categorie
    {
        public string Nume { get; set; }
        public int CapacitateMotor { get; set; }
        public int Greutate { get; set; }

        public Categorie(string nume, int capMotor, int greutate)
        {
            this.Nume = nume;
            this.CapacitateMotor = capMotor;
            this.Greutate = greutate;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", Nume, CapacitateMotor, Greutate);
        }
    }
}
