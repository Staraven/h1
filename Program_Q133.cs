using System;
using System.Linq.Expressions;

namespace RepeatLesson
{
    public class Program_Q133
    {
        public static void Main_Q133(string[] args)
        {
           Console.Write("Input the size of array : ");
           int number = Convert.ToInt32(Console.ReadLine());
           int [] array = new int [number];
           int [] insertedarray = new int [number+1];
           Console.WriteLine(" ");

           Console.Write("Input "+number+" elements in the array in ascending order: ");
           Console.WriteLine(" ");
           for (int i = 0; i < number; i++)
           {
            Console.Write("element - "+i+" : ");
            array[i] = Convert.ToInt32(Console.ReadLine());


           }
           Console.Write("Input to be inserted : ");
           int num = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("The exist array list is : ");
           int p=0;
           for (int i = 0; i < number; i++)
           {
            for (int j = 0; j < number-1; j++)
            {
                if (array[j]> array[j+1])
                {
                    p = array[j+1];
                    array[j+1] = array[j];
                    array[j] = p;
                }
            }
           }
           
            for (int i = 0; i < number; i++)
            {
                Console.Write(array[i]+" ");
            }
            Console.WriteLine(" ");
            Console.Write("After the insert list is : ");
            insertedarray[0] = num;
            for (int i =0; i < number; i++)
            {
                insertedarray[i+1] = array[i];
            }
            int c=0;
                for (int i = 0; i < number+1; i++)
                {
                    for (int j = 0; j < number; j++)
                    {
                        if (insertedarray[j]>insertedarray[j+1])
                        {
                           c = insertedarray[j+1];
                           insertedarray[j+1] = insertedarray[j];
                           insertedarray[j]=c;

                        }
                    }
                }
                for (int i = 0; i < number+1; i++)
                {
                    Console.Write(insertedarray[i]+" ");
                }
                            }
            
            
        }


}
    
