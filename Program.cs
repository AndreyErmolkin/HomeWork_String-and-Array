using System;

namespace HomeWork_String_and_Array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter element n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter element m:");
            int m = int.Parse(Console.ReadLine());
            int[,] myArr = new int[n, m];
            int i, j = 0;
            int number = 0;

            Random ran = new Random();

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    myArr[i, j] = ran.Next(1, 20);
                    Console.Write("{0}\t", myArr[i, j]);
                }
                Console.WriteLine();
            }

            for (i = 0; i <= myArr.GetUpperBound(0); i++)
            {
                int max = 0;
                for (j = 0; j <= myArr.GetUpperBound(1); j++)
                {
                    if (myArr[i, j] > max)
                    {
                        max = myArr[i, j];
                    }
                }
                bool IsMax = false;
                for (j = 0; j <= myArr.GetUpperBound(1); j++)
                {
                    if (IsMax == true)
                    {
                        Console.Write(0 +"\t"+" ");
                    }
                    else
                    {
                        Console.Write(myArr[i, j] +"\t" + " " ) ;
                    }
                    if (myArr[i, j] == max)
                    {
                        IsMax = true;
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
