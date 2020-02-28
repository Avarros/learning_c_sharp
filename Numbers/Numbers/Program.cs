using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Abs(-43));/*absolute value*/
            Console.WriteLine(Math.Pow(-43,54));/*1st number to the power of 2nd number*/
            Console.WriteLine(Math.Sqrt(-43));/*square root of a number */
            Console.WriteLine(Math.Max(-43,43));/*highest number*/
            Console.WriteLine(Math.Min(-43, 43));/*lowest number*/
            Console.WriteLine(Math.Round(4.51));/*rounding a number*/
            Console.ReadLine();
        }
    }
}
