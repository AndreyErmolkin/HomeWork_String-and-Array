using System;


namespace HomeWork_String_and_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[8] { 7, -65, 87, 348, -734, -43, 724, 652 };
            
            foreach (int i in numbers)
            {
                
                if (i <= 0)
                {
                   
                    Console.WriteLine("Отрицательное число =" + i); 
                }


              
            }
            int lastMin = int.Parse(Console.ReadLine());
            Console.WriteLine("Номер числа:"+ Array.IndexOf(numbers, lastMin));
            

        }


    }
}