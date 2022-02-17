using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorozatKiir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg az utolsó értéket! ");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (szam > 1)
            {
                for (int i = 1; i <= szam; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Rossz érték!");
            }
            Console.ReadKey();
        }
    }
}
