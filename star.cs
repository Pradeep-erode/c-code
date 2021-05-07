using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int i,star;
            Console.Write("Number of star you required :");
            star = Convert.ToInt32(Console.ReadLine()); 

            for (i = 0; i <= star; i++)
            {
                    Console.Write("*\n");
                
            }

        }
    }
}




