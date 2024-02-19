using System;

namespace RepeatLesson
{
    public class Program_Q4
    {
        public static void Main_Q4(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the array :");
            int number = Convert.ToInt32(Console.ReadLine());
            int [] array = new int[number];

            Console.WriteLine("Input "+number+" elements in the array :");
            for (int i = 0; i < number; i++)
            {
                Console.Write("element - "+i+ " : ");
                array[i] = Convert.ToInt32(Console.ReadLine());

            }

                int [] array2 = new int [number];
                for (int i = 0; i < number; i++)
                {
                    array2[i]=array[i];

                }
                Console.WriteLine("The elements stored in the first array are : ");
                
                for (int i = 0; i < number; i++)
                {
                    Console.Write(array[i]);
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
                Console.WriteLine("The elements copied into the second array are : ");
                for (int i = 0; i < number; i++)
                {
                    Console.Write(array2[i]);
                    Console.Write(" ");
                }
                
                
        }

    }
}
