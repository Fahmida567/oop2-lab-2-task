using System;

namespace lab_2_task
{
    class Program
    {

        static void Main(string[] args)
        {
            //1
            /*Console.WriteLine("-----------Question 1 answer-------------");
            Console.WriteLine();
            for (int i = 0; i <= 10; i++)
            {
                int x = i % 2;
                if (x == 0)
                {
                    Console.Write(i + " ");
                }
            }*/


            //2
            /* Console.WriteLine("-----------Question 2 answer----------");
             Console.WriteLine();
             int x = 0;
             for (int i = 0; i < 4; i++)
             {
                 for(int j = 0; j <= 5; j++)
                 {
                     x = i + j;
                     if (x%2==0)
                     {
                         Console.Write("x");
                     }
                     else
                     {
                         Console.Write("0");
                     }


                 }
                 Console.WriteLine();
             }*/
            //3
            /* Console.WriteLine("-----------Question 3 answer----------");
             Console.WriteLine();
             int x = 0;
              for (int i = 1; i <=6; i++)
              {
                  x = i;
                  for (int j = 0; j <= 3; j++)
                  {


                          Console.Write(x+j);




                  }
                  Console.WriteLine();
              }
              Console.ReadLine();*/


            //4.
            /* Console.WriteLine("-----------Question 4 answer----------");
             Console.WriteLine();
             int sumOfEven = 0;  
         int sumOfOdd = 0;

         for (int i = 1; i <= 100; i++)
         {
             if (i % 2 == 0)
                 sumOfEven =sumOfEven+i;
             else
                 sumOfOdd =sumOfOdd+ i;
         }

         Console.WriteLine("The even sum is : " + sumOfEven);
         Console.WriteLine("The odd sum is : " + sumOfOdd);*/

            //5
            /* Console.WriteLine("-----------Question 5 answer----------");
             Console.WriteLine();

             for (int i = 1; i <= 5; i++)
             {
                 for (int j = 1; j <= 5; j++)
                 {
                     if (i == j)
                         Console.Write(i);
                     else
                         Console.Write("  ");
                 }
                 Console.WriteLine();
             }*/
            //6
            /* Console.WriteLine("-----------Question 6 answer----------");
             Console.WriteLine();
             Console.WriteLine("Enter number: ");
              long a = Convert.ToInt32(Console.ReadLine());
              long f = 1;
              for (int i = 1; i <= a; i++)
              {
                  f *= i;
              }
              Console.WriteLine("Factorial is:"+f);*/

            //7
            /*Console.WriteLine("-----------Question 7 answer----------");
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
             {
                 if (i <= 5)
                 {
                     for (int k = 1; k <= i; k++)
                     {
                         Console.Write("*");
                     }
                 }
                 else
                 {
                     for (int k = 4; k>= i - 5; k--)
                     {
                         Console.Write("*");
                     }
                 }
                 Console.WriteLine();
             }*/
        }
    }
       }

