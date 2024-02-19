using System;
using System.Linq.Expressions;

namespace RepeatLesson
{
    public class Program_Q10
    {
        public static void Main_Q10(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the array : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int [] array = new int [number];

            Console.WriteLine("Input "+number+" elements in the array : ");
            for (int i = 0; i < number; i++)
            {
                Console.Write("element - "+i+" : ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
                int [] arrayodd = new int [number];
                int [] arrayeven = new int [number];

                int h =0;
                int a =0;

            
                for (int i = 0; i < number; i++)
                {
                    if (array[i] %2 == 0)
                    {
                        arrayeven[h]= array[i];
                        h++;
                        
                    }
                    else
                    {
                        arrayodd[a] = array[i];
                        a++;
                        
                    }
                    
                    

                }

                Console.WriteLine("The Even elements are: ");
                for (int i = 0; i < h; i++)
                {
                    Console.Write(arrayeven[i]);
                }
                    Console.WriteLine(" ");
                Console.WriteLine("The Odd elements are: ");
                for (int i = 0; i < a; i++)
                {
                    Console.Write(arrayodd[i]);
                }
        }


}
    }

