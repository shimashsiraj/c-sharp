using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int width = UserInput("Enter Width: ");

            int height = UserInput("Enter Height: ");

            CalcArea(width, height);
        }


        static int UserInput(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        static void CalcArea(int width, int height)
        {
            int area = (width * height) / 2;
            Console.WriteLine($"Area of Triangle: {area}");

        }
    }
}
