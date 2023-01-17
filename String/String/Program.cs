using System;


namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt";
            Console.WriteLine(phrase.IndexOf("sit"));/*shows where it starts,if it doesn't exist it outputs -1*/
            Console.WriteLine(phrase.IndexOf('o'));/*shows where the first instance of it is,if it doesn't exist it outputs -1*/
            Console.WriteLine(phrase.Substring(8));/*grabs something from a given place right to the end*/
            Console.WriteLine(phrase.Substring(8,6));/*grabs something from a given place right to the end,second number is how many characters we want to get*/
            Console.ReadLine();
        }
    }
}
