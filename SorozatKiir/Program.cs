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
            Console.Write("Adja meg a kezdő értéket! ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg az utolsó értéket! ");
            int max = Convert.ToInt32(Console.ReadLine());
            if (max > 1 && max!=min && max > min )
            {
                for (int i = min; i <= max; i++)
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
