using System;
using System.Linq.Expressions;

namespace RepeatLesson
{
    public class Program
    {
        public static void Main(string[] args)
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
             Console.Write("Input the value to be inserted : ");
           int num = Convert.ToInt32(Console.ReadLine());

           Console.Write("Input the Position, where the value to be inserted :");
           int num2 = Convert.ToInt32(Console.ReadLine());

           for (int i = 0; i < num2; i++)
           {
            insertedarray[i] = array[i];
           }
           
           insertedarray[num2-1] = num;

           for (int i = num2-1; i <number; i++)
           {
            insertedarray[i+1] = array[i];
           }
           
           Console.WriteLine("The current list of the array : ");
           for (int i = 0; i < number; i++)
           {
            Console.Write(array[i]+" ");

           }
           Console.WriteLine(" ");
           Console.WriteLine("After Insert the element the new list is :");
           for (int i = 0; i < number+1; i++)
           {
            Console.Write(insertedarray[i]+" ");
           }
            
           

           
            
        }


}
    


}