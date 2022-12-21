using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello");
            //هنطلب من البوزر انه يدخل الرقم الاول 
            Console.WriteLine("Please enter the first number:");
            // هنا هنخزن القيمه اللي اليوزر دخلها في متغير int
            int first = int.Parse(Console.ReadLine());

            //وهنا الرقم الثاني 
            Console.WriteLine("Please enter the second number:");
            // وهنا هناخدها ونخزنها في متغيرint برضوا
            int second = int.Parse(Console.ReadLine());
            // هنا هنبدا نطبع 
            Console.WriteLine("The Prime Numbers");
            //هنستخدم التكرار بي for

            for (int a=first; a<=second; a++)  //دي التكرارات اللي بين الارقام اللي اليوزر دخلهم
            {// هنا هتبدا التكرارات بتاعت الfor loop
                // من اول هنا هيبدا البرنامج بفحص الارقام اللي اليوزر دخلهم واللي بينهم وهيبدا بطباعه الارقام الاوليه فقط
                bool IsPrimeNumber = true; 
                   if (a==2 || a == 3)
                   {
                    Console.WriteLine(a);
                   }
                   else if(a==1 || a % 2 == 0)
                   {
                    continue;
                   }
                   else
                   {
                      for (int s=3; s<=Math .Sqrt (a); s+=2)
                      { 
                        if (a % s == 0)
                        {
                            IsPrimeNumber = false;
                            break;
                        }
                      }
                      if (IsPrimeNumber)
                      {
                        Console.WriteLine(a);
                      }

                   }




            }
            Console.WriteLine("end");
            Console.ReadKey();

        }
    }
}
