using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Héritage.Entities
{
    public abstract class Forme
    {
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public Forme(String name)
        {
            this.Name = name;
        }

        public abstract double aire();
        public abstract double perimetre();

        public override abstract string ToString();

    }
}
