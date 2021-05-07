using System;

namespace ConsoleApp2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int a,b;
            char c;//operators can be stored as char type
            Console.WriteLine("Enter first value:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Eneter second value");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter add 1 or sub 2:");
            c = Convert.ToChar(Console.ReadLine());//type convertion to character

            switch (c)
            {
                case '+':
                    Console.Write("sum=" + (a + b));
                    break;
                case '-':
                    Console.Write("subract=" + (a - b));
                    break;
                default:
                    Console.Write("try to write correct number");
                    break;
            

            
            }

        }
    }
}
