using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Héritage.Entities
{
    public class Triangle : Forme
    {
        private double coteA;
        private double coteB;
        private double coteC;

        public Triangle() : base("Triangle")
        {
        }

        public Triangle(string name) : base(name)
        {
        }

        public double A
        {
            get { return coteA; }
            set { coteA = value; }
        }
        public double B
        {
            get { return coteB; }
            set { coteB = value; }
        }
        public double C
        {
            get { return coteC; }
            set { coteC = value; }
        }

        public override double aire()
        {
            double p = perimetre() /2 ;
            double calcul = p * (p-coteA) * (p-coteB) * (p-coteC);
            return Math.Sqrt(calcul);
        }
        public override double perimetre()
        { 
            return coteA + coteB + coteC;
        }

        public override string ToString()
        {
            String msg = "Triagnel de coté A=" + coteA + ", B=" + coteB + " et C=" + coteC;
            msg += "\nAire = ";
            msg += aire();
            msg += "\nPérimètre = ";
            msg += perimetre();
            msg += "\n";
            return msg;
        }
    }
}
