using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
       
            #region task 1 Verilmiş 4 ədəddən tək olanlarının cəmini tapın.

            int n1 = 4;
            int n2 = 7;
            int n3 = 5;
            int n4 = 3;
            int count = 0;
            if (n1 % 2 != 0){count += n1;}
            if (n2 % 2 != 0){count += n2;}
            if (n3 % 2 != 0){count += n3;}
            if (n4 % 2 != 0){count += n4;}
            Console.WriteLine(count);

            #endregion
           

            /**
            #region task 2 Verilmiş düzbucaqlı şkafın hər hansı bir qapıdan keçib-keçməyəcəyini  tapan algoritm yazın

            double a = 2.1;
            double b = 2.1;
            double x = 2;
            double y = 2;
            double z = 1.9;
            if (a > x && b > y || a > y && b > x || a > x && b > z || a > z && b > x || a > z && b > y ||
                a > y && b > z)
            {
                Console.WriteLine("skhaf kechir");
            }
            else
            {
                Console.WriteLine("skhaf kechmir");
            }


            #endregion
 **/
        }
    }
}