using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter name: ");/*there is write instead of write line because we don't want to print and go to the next line but to stay in the same line*/
            string name = Console.ReadLine();/*user input saved to variable string named "name"*/
            Console.WriteLine("Hi " + name + "!");
            Console.ReadLine();
        }
    }
}
