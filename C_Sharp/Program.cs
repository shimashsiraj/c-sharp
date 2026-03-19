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

            //Printing Hello World to the console
            Console.WriteLine("Hello World!");

            //variables

            //integer
            //int age = 22;
            //Console.WriteLine(age);


            ////long
            //long bigNumber = 9000000000L;
            //Console.WriteLine(bigNumber);

            ////double
            //double negative = -55.8D;
            //Console.WriteLine(negative);

            ////float
            //float precision = 5.00001F;
            //Console.WriteLine(precision);


            //methonds of initializing variables
            //1
            //int x;
            //int y;
            //int z;

            //2
            int x, y, z;

            //string conversion

            //integer
            string textAge = "22";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);


            //long
            string textBigNumber = "9000000000";
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bigNumber);

            //double
            string textNegative = "-55.8";
            double negative = Convert.ToDouble(textNegative);
            Console.WriteLine(negative);

            //float
            string textPrecision = "5.00001";
            float precision = Convert.ToSingle(textPrecision);
            Console.WriteLine(precision);
        }
    }
}
