using System;

namespace ScontoNegozio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci l'importo");
            double t = double.Parse(Console.ReadLine());
            double s1 = (t * 10) / 100;
            double s2 = (t * 20) / 100;
            if (t <= 500)
            {
                double importo = t - s1;
                Console.WriteLine($"l'importo totale è {importo} ");
                Console.ReadLine();
            }
            if (t > 500)
            {
                double importo = t - s2;
                Console.WriteLine($"l'importo totale è {importo} ");
                Console.ReadLine();
            }
        }
    }
}
