using System;

namespace RepeatLesson
{
    public class Program_Q7
    {
        public static void Main_Q7(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the first array :");
            int number = Convert.ToInt32(Console.ReadLine());
            int [] array = new int [number];
            Console.WriteLine(" ");

            Console.WriteLine("Input "+number+ " elements in the array :");
            for (int i = 0; i < number; i++)
            {
                Console.Write("element - "+i+" : ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Input the number of elements to be stored in the second array : ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int [] array2 = new int [number2];
            Console.WriteLine(" ");
            
            Console.WriteLine("Input "+number2+ " elements in the array : ");
            for (int i = 0; i < number2; i++)
            {
                Console.Write("element - "+i+" : ");
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }

            int [] mergedarray = new int[number+number2];
            for (int i = 0; i < number; i++)
            {
                mergedarray[i] = array[i];
            }
            for (int i = 0; i < number2; i++)
            {
                mergedarray[i+number] = array2[i];
            }

           Console.WriteLine("The merged array in ascending order is : ");
           int p = 0;
           for (int i = 0; i < number+number2; i++)

           {
            for (int j = 0; j < number+number2-1; j++)
            {
                if (mergedarray[j] > mergedarray[j+1])
                {
                    p = mergedarray[j+1];
                    mergedarray[j+1] = mergedarray[j];
                    mergedarray[j] = p;
                } 
                
            }
           }
            for (int i = 0; i < number+number2; i++)
            {
                Console.Write(mergedarray[i]);
                Console.Write(" ");
            }

            
                
        }

    }
}
