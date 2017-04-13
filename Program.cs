using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableOfPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sqr;
            int cbe;
            char yes;

            do
            {
                Console.WriteLine("Please enter an integer: ");

                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("You did not enter an integer!");
                }
                else
                {
                    Console.WriteLine("\t\tNumber\t\tSquared\t\tCubed\t\t");
                    Console.WriteLine("\t\t======\t\t=======\t\t=====\t\t");

                    for (int i = 1; i <= num; i++)
                    {
                        sqr = (i * i);
                        cbe = (i * i * i);
                        Console.WriteLine("\t\t{0}\t\t{1}\t\t{2}\t\t", i, sqr, cbe);
                    }

                    Console.WriteLine("Continue? (y/n): ");

                    if (!char.TryParse(Console.ReadLine(), out yes))
                    {
                        Console.WriteLine("You did not enter 'y' or 'n', please try again.");
                    }
                    else if (yes == 'y')
                    {
                        continue;
                    }
                    else
                    {
                        return;
                    }
                }
            } while (true);
        }
    }
}
