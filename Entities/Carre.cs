using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Héritage.Entities
{
    public class Carre : Forme
    {
        private double longueur; 
        public Carre(): base("Carré")
        {

        }
        public Carre(string name) : base(name)
        {
        }

        public double Longueur
        {
            get { return longueur; }
            set { longueur = value; }
        }

        public override double aire()
        {
            return longueur * longueur;
        }
        public override double perimetre()
        {
            return longueur *4;
        }

        public override string ToString()
        {
            String msg = "Carré de coté = " + longueur;
            msg += "\nAire = ";
            msg += aire();
            msg += "\nPérimètre = ";
            msg += perimetre();
            msg += "\n";
            return msg;
        }
    }
}
