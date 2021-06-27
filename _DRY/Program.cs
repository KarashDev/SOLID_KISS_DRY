using System;

namespace _DRY
{
    //Don’t Repeat Yourself / Не повторяйтесь
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = new int[] { 12, 215, 23, 57, 83 };
            var array2 = new int[] { 55, 76, 36, 845, 22 };
            var array3 = new int[] { 8, 56, 25, 88, 131 };
            
            //ПЛОХО
            foreach (var number in array1)
            {
                Console.WriteLine(number);
            }
           
            foreach (var number in array1)
            {
                Console.WriteLine(number);
            }
           
            foreach (var number in array3)
            {
                Console.WriteLine(number);
            }

            //ХОРОШО
            static void PrintArray(int[] array)
            {
                foreach (var number in array)
                {
                    Console.WriteLine(number);
                }
            }
            PrintArray(array1);
            PrintArray(array2);
            PrintArray(array3);


        }
    }
}
