using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace Tafelkaart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een getal in");
            int n = int.Parse(Console.ReadLine());
            Fibonacci(n);

            Console.WriteLine();
            Console.Write("Voer een getal in voor de tafelkaart: ");
            n = int.Parse(Console.ReadLine());
            Tafelkaart(n);
        }

        static void Fibonacci(int n)
        {
            long a = 1, b = 2;
            var reeks = new List<long>();

            for (int i = 0; i < n; i++)
            {
                reeks.Add(a);
                long volgende = a + b;
                a = b;
                b = volgende;
            }

            Console.WriteLine(string.Join(", ", reeks));
        }

        static void Tafelkaart(int n)
        {
            string kop = "Tafel van".PadRight(10);
            for (int kolom = 1; kolom <= n; kolom++)
            {
                kop += kolom.ToString().PadRight(6);
            }
            Console.WriteLine(kop);

            for (int rij = 1; rij <= n; rij++)
            {
                string regel = rij.ToString().PadRight(10);
                for (int kolom = 1; kolom <= n; kolom++)
                {
                    regel += (rij * kolom).ToString().PadRight(6);
                }
                Console.WriteLine(regel);
            }
        }
    }
}
