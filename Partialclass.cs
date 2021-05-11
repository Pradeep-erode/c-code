using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arr = new object[] { 9, "father", "child" };
            Console.WriteLine(arr[1]); 
            Man obj = new Man();
            Console.WriteLine("without set and get :" + obj.naam);
            obj.maan = "bablu";
            Console.WriteLine("After setting set and get:" + (obj.maan));
            user1 obj2 = new user1("balu", 34);
            obj2.idprint();

            
        } 
    }

    /// <summary>
    /// Get and Set class
    /// </summary>

    public class Man
    {
        public string naam;
        public string maan
        {
            get { return naam; }
            set{ naam = value +"paikl"; }
        }
    }
    public partial class user1        //partial class
    {
        private string name;
        private int id = 5;
        partial void nameprint();     //partial method declaration
        public user1(string name, int id) 
        {
            this.name = name;
            this.id = id;
            
        }

    }
    public partial class user1        //partial class
    {
        public void idprint()
        {
        Console.WriteLine(id);
        }
        partial void nameprint()       //partial method implementation within partial class
        {
            Console.WriteLine(name);
        }
    }
    

}
