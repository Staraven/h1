using System;

namespace RepeatLesson
{
    public class Program_Q1
    {
        public static void Main_Q1(string[] args)
        {
            int[]number = new int[10];

           Console.WriteLine("Input 10 elements in the array");
           for(int i = 0; i < 10; i++)
           {
            Console.Write ("Element -" + i + " :");
            number[i] = Convert.ToInt32(Console.ReadLine());
           }

            Console.Write("Elements in the array are: ");
           for(int i = 0; i < 10; i++)
           {
            Console.Write(number[i] +" ");
           }





        }

    }
}
