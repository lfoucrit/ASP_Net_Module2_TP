using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Héritage.Entities
{
    public class Cercle : Forme
    {
        private double rayon;
        public Cercle() : base("Cercle")
        {

        }
        public Cercle(string name) : base(name)
        {

        }

        public double Rayon
        {
            get { return rayon; }
            set { rayon = value; }
        }

        public override double aire()
        {
            return rayon * rayon * Math.PI;
        }
        public override double perimetre()
        {
            return 2 * Math.PI * rayon;
        }

        public override string ToString()
        {
            String msg = "Cercle de rayon " + rayon + " \nAire = ";
            msg += aire();
            msg += "\nPérimètre = ";
            msg += perimetre();
            msg += "\n";
            return msg;
        }
    }
}
