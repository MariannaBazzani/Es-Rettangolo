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

        public override string ToString()
        {
            return string.Format($"Sono un rettangolo di altezza: {0} e base: {1}", Altezza, Base);
        }
    }
}
