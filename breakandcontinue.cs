using System;

namespace break_and_continue
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Hello World!");
            for (int i = 1; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    if (i==2 && j==2)
                    {
                        break;
                    }
                   
                    
                        Console.Write( i + " " + j);
                    Console.Write("\n");


                }

            }
        }
    }
}
