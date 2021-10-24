using System;

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
              **/

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
        }
    }
}