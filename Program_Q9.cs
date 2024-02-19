using System;

namespace RepeatLesson
{
    public class Program_Q9
    {
        public static void Main_Q9(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the array :");
            int number  = Convert.ToInt32(Console.ReadLine());
            int [] array  = new int [number];
            Console.Write(" ");

            Console.WriteLine("Input "+number+" elements in the array :");

            for (int i = 0; i < number; i++)
            {
                Console.Write("element - "+i+" :");
                array[i]= (Convert.ToInt32(Console.ReadLine()));

            }
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
            Console.Write("Maximum element is : "+array[number-1]);
            Console.WriteLine(" ");
            Console.Write("Minimum element is : "+array[0]);
                
        }

    }
}
