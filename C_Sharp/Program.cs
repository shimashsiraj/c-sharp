using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List <int> even = new List<int>();
            List <int> odd = new List<int>();

            for (int i = 0; i <= 20; i++)
            {
                if(i % 2 == 0)
                {
                    even.Add(i);

                }
                else if(i % 2 == 1)
                {
                    odd.Add(i);
                }
                
            }

            Console.WriteLine("Printing Even Numbers: ");

            foreach (var i in even)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine(Environment.NewLine + "Printing Odd Numbers: ");

            foreach (var i in odd)
            {
                Console.Write($"{i} ");
            }

        }
    }
}
