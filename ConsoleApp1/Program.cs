using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digit a word");

            var objeto = Console.ReadLine();

            string newValue = string.Empty;
            int i = 1;
            foreach( var value in objeto)
            {               
                 newValue += objeto[objeto.Length - i];
                i++;
            }

            if(objeto == newValue)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.ReadKey();

        }
    }
}
