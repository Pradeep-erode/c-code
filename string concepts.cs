using System;
using System.Collections.Generic;
namespace Stringsplit_and_concatenation
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstname = "pradeep";
            string lastname = "kumar";
            string ba = "ram";

            //Upper and LOwer case change
            string upper = firstname.ToUpper();

            //Interpolation==Insert one string in another string
            string interpolation =$"hi,I am {upper + lastname} working in span";

            //string.Concat== simply combine string in 1 string
            string conc = string.Concat(upper + " " +lastname);

            //string.Format==combine string in a standerd array format
            string name = string.Format("hi,{0}{1}{2} your first name is {0}.your lastname is {1}.your old{2}" , upper, lastname,ba);
             
            Console.WriteLine(name);

            string msg = "Suresh,Rohini,Trishika,-Praveen%Sateesh";

            string msge = msg.Replace("Suresh","prakash");

            string[] strarr = msge.Split(new char[] { ',', '-', '%' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string stra in strarr)
            {
                Console.WriteLine(stra);
            }
            Console.WriteLine("\n");

               //for more than one delimiter we can give like this
            string[] strin= { "h", "a" };

            //Here we can set splitting count
            Int32 count = 5;  
            
           
            string[] a = msg.Split(strin,count, StringSplitOptions.RemoveEmptyEntries);
            
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();

            /*foreach (string r in a)
            {
                Console.WriteLine(r);
            }
            Console.ReadLine();
            */
            string name1 = "Suresh";
            string name2 = ", " + "Rohini";
            string name3 = ", " + "Trishika";
            Console.WriteLine("Users: {0}", string.Concat(name1, name2, name3));

        }



    }
    public class stringsplit
    {
    }
    
}
