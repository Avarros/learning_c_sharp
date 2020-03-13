using System;

namespace conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num =Convert.ToInt32("32"); /*CONVERTING STRING TO INT*/
            Console.WriteLine(num);
            Console.Write("Enter number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());/*Converts user input (string) to int*/
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());/*Converts user input (string) to int*/
            Console.WriteLine(num1+num2);
        }
    }
}
