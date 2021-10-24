using System;
using System.Xml;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /**

            #region task 1 Verilmiş 4 ədəddən tək olanlarının cəmini tapın.

            int n1 = 4;
            int n2 = 7;
            int n3 = 5;
            int n4 = 3;
            int count = 0;
            if (n1 % 2 != 0)
            {
                count += n1;
            }

            if (n2 % 2 != 0)
            {
                count += n2;
            }

            if (n3 % 2 != 0)
            {
                count += n3;
            }

            if (n4 % 2 != 0)
            {
                count += n4;
            }

            Console.WriteLine(count);

            #endregion



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


            #region task-3 Verilmiş n tam ədədinin sadə və ya mürəkkəb ədəd olduğunu tapın

            int eded = 97;
            if (eded < 2)
            {
                Console.WriteLine("eded ne sade nede murebekdir");
            }

            if (eded == 2)
            {
                Console.WriteLine(eded + "- sade ededir");
            }
            else
            {
                for (int i = 2; i * i <= eded; i++)
                {
                    if (eded % i == 0)
                    {
                        Console.WriteLine("murekkeb");
                        return;

                    }

                }

                Console.WriteLine("sade");

            }

            #endregion


            #region Task-4 Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın.

            int num = 695845;
            int reqemsayi = 0;
            while (num >= 1 || num <= -1)
            {
                num /= 10;
                reqemsayi++;
            }

            Console.WriteLine(reqemsayi);

            #endregion


            #region Task-5 String array və string qəbul edən bir algoritm yazın, əgər string array-də varsa true, yoxdusa false yazdırsın.

            string[] adlar = {"cavid", "togrul", "hezret", "murad", "asim"};
            string ad = "murad";
            bool advarmi = false;
            for (int i = 0; i < adlar.Length; i++)
            {
                if (adlar[i] == ad)
                {
                    advarmi = true;
                    break;
                }
            }

            Console.WriteLine(advarmi);

            #endregion


            #region Task-6 Number array-in ən böyük elementini tapın.

            int[] numberarr =
            {
                25, 2, 4, 5, 34, 54, 23, 43, 23, 43, 23,
                54, 67, 54, 5, 4, 516, 3, 98, 76, 56, 76, 45, 37, 84, 9, 3, 102
            };
            int enboyuk = numberarr[1];
            for (int i = 0; i < numberarr.Length; i++)
            {
                if (numberarr[i] > enboyuk)
                {
                    enboyuk = numberarr[i];
                }
            }

            Console.WriteLine(enboyuk);


            #endregion


            #region Task-7 Number array-ini kiçikdən böyüyə doğru düzün.

            int[] numbers =
                {16, 2, 4, 5, 45, 45, 78, 85, 2, 3, 1, 4, 5, 6, 8, 7, 23, 96, -98, 9, 12, -23, -74, 523, 63};
            int bn = 0;
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                for (int c = i + 1; c < numbers.Length; c++)
                {
                    if (numbers[i] > numbers[c])
                    {
                        bn = numbers[i];
                        numbers[i] = numbers[c];
                        numbers[c] = bn;
                    }
                }
            }

            foreach (int VARIABLE in numbers)
            {
                Console.Write(VARIABLE + ",");
            }

            #endregion
**/

            #region Task-8 eded 7 ye qaliqsiz  bolunurse ozunu eks halda en yaxin ededi goster

            int m = 20;
            if (m % 7 != 0)
            {
                if (m % 7 > (7 / 2))
                {
                    Console.WriteLine(m - (m % 7) + 7);
                }
                else
                {
                    Console.WriteLine(m - (m % 7));
                }

            }
            else
            {
                Console.WriteLine(m);
            }


            #endregion
        }
    }
}