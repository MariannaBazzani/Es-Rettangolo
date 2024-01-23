using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Rettangolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rettangolo rettangolo = new Rettangolo();
            Console.WriteLine("Inserisci base: ");
            rettangolo.Base = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci altezza: ");
            rettangolo.Altezza = int.Parse(Console.ReadLine());

            Console.WriteLine("Area : " + rettangolo.Area());
            Console.WriteLine("Perimetro: " + rettangolo.Perimetro());

            Rettangolo quadrato = new Rettangolo();
            Console.WriteLine("Inserisci base: ");
            quadrato.Base = quadrato.Altezza = int.Parse(Console.ReadLine());

            Console.WriteLine("Area: " + quadrato.Area());
            Console.WriteLine("Perimetro: " + quadrato.Perimetro());
        }
    }
}
