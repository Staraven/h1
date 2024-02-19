using System;
using System.Linq.Expressions;

namespace RepeatLesson
{
    public class Program_Q11
    {
        public static void Main_Q11(string[] args)
        {
           Console.Write("Input the size of array :");
           int number = Convert.ToInt32(Console.ReadLine());
           int [] array = new int [number];
           Console.WriteLine(" ");
           Console.WriteLine("Input "+number+" elements in the array :");
           for (int i = 0; i < number; i++)
           {
            Console.Write("element - "+i+" : ");
            array[i] = Convert.ToInt32(Console.ReadLine());
           }
            Console.Write(" ");
            Console.WriteLine("Elements of array sorted in ascending order : ");
            int p = 0;
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number-1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        p = array[j+1];
                        array[j+1] = array[j];
                        array[j] = p;
                    }
                }
            }
            for (int i = 0; i < number; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
        }


}
    }

