using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {

            ///Dimensional array with forloop input and output with forloop 

            int[,] arre = new int[3, 4];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arre[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine("hello");


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(arre[i, j] + "\t");
                }

                Console.WriteLine();
            }
            

            Verticle ver = new Verticle();
            ver.main();
            Console.WriteLine();
            Problm dev = new Problm();
            Pot cat = new Pot(3,4);
            Blue wale = new Blue();
            wale.norm(34,"blu");
        }
    }

    /// <summary>
    /// Jagged array and print using foreach
    /// </summary>
    /// 

    public class Verticle
    {
        public void main()
        {
            int[][] arr = new int[2][];         //once mentioned  like this space is alloted for 2 row of arrays
            arr[0] = new int[] { 3, 5, 6, 7, 6 };
            arr[1] = new int[] { 2, 3, 4 };

            /* as jagged array is==array within the array so first store it in another array*/
            /*another array==int[]ar*/

            foreach (int[] ar in arr)           
                               
            {
              foreach (int item in ar)        
                 {
                   Console.Write(item + "\t");
                 }
                Console.WriteLine();
            }                            
            /*for (int i = 0; i < arr.Length; i++)
            {
                 for (int j = 0; j < arr[i].Length; j++)
                 {
                    Console.Write(arr[i][j] + " ");
                 }
                   Console.WriteLine();
             }

            */

        }
    }



    /// <summary>
    /// constructor class
    /// </summary>


    public class Problm
    {
        public int d;
        public Problm()
        {
            Console.WriteLine("I am constructor:" + d);
        }
    }
    public class Pot
    {
        public Pot(int a, int b)
        {
            Console.WriteLine(+(a+b));
        }
    }


    /// <summary>
    /// parameterized constructor
    /// </summary>
    /// 
    public class Blue
    {
        int id = 0;
        string name = "";
        public void norm(int id,string name)
        {
            this.id = id;
            this.name = "bery";
            Console.Write("your id is :"+ id);
            Console.Write("your name is :" + name);
        }
    }


 }

