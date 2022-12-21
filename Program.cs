using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perefect_Number
{
    internal class Program
    {
        static bool isnumber(int number)
        {
            int sum = 0;
            for (int s = 1; s < number; s++)
            {
                if (number % s== 0) sum = sum + s;
            }
            if (sum == number) return true;
            return false;

        }
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Hello");
                Console.WriteLine(" please enter start number: ");
                int i = int.Parse(Console.ReadLine());

                Console.WriteLine("please enter end number: ");
                int v = int.Parse(Console.ReadLine());

                for (int a = i; a <= v; a++)
                {
                    if (isnumber(a)) Console.WriteLine("{0},", a);

                }
                Console.WriteLine("End");
               Console.ReadKey ();
            }
        }
    }
}
