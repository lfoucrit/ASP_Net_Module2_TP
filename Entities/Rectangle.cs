using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Héritage.Entities
{
    public class Rectangle:Forme
    {
        private double largeur;
        private double longueur;
        public Rectangle() : base("Rectangle")
        {

        }
        public Rectangle(string name) : base(name)
        {

        }

        public double Largeur
        {
            get { return largeur; }
            set { largeur = value; }
        }

        public double Longueur
        {
            get { return longueur; }
            set { longueur = value; }
        }

        public override double aire()
        {
            return longueur * largeur;
        }
        public override double perimetre()
        {
            return (longueur + largeur) * 2;
        }

        public override string ToString()
        {
            String msg = "Rectangle de longueur = " + longueur + " et largeur = " + largeur;
            msg += "\nAire = ";
            msg += aire();
            msg += "\nPérimètre = ";
            msg += perimetre();
            msg += "\n";
            return msg;
        }
    }
}
