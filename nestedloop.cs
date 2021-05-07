using System;

namespace ConsoleApp3
{
    class printt
    {
        public void print()
        {
            
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {

            printt dog = new printt();
            dog.print();
            int i, j, star;
            Console.Write("Input number of rows of star : ");
            star = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= star; i++)
            {
                for (j = 1; j <= i; j++)
                
                    Console.Write("*");
                    Console.Write("\n");
                
            }
        }
    }
}
