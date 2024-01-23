using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Rettangolo
{
    internal class Rettangolo
    {
        public int Altezza { get; set; }
        public int Base { get; set; }

        public double Area()
        {
            return Base * Altezza;
        }

        public int Perimetro()
        {
            return 2 * (Base + Altezza);
        }
    }
}
