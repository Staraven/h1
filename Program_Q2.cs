using System;

namespace RepeatLesson
{
    public class Program_Q2
    {
        public static void Main_Q2(string[] args)
        {
            

           Console.WriteLine("Input the number of elements in the array :");
           
           int number = Convert.ToInt32(Console.ReadLine());

           int [] num = new int [number];
           
           Console.WriteLine("Input "+number+ "number of elements in the array :");
           for(int i = 0; i < number; i++)
           {
            Console.Write ("Element -" + i + " :");
            num[i] = Convert.ToInt32(Console.ReadLine());
           }
           

            Console.WriteLine("The values store into the array are:");
           for(int i = 0; i < number; i++)

           {
            Console.Write(num[i] +" ");
           }
            Console.WriteLine(" ");
           Console.WriteLine("The values store into the array in reverse are :");
           for (int i = number-1; i >=0; i--)

           {
            Console.Write(num[i] + " ");
           }





        }

    }
}
