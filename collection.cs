using System;
using System.Collections;
using System.Collections.Generic;


namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            arraylist objec = new arraylist();
            hashtabel object2 = new hashtabel();
            object2.hash();
            queue obj = new queue(3, "praveen");
            stackk obj3 = new stackk();
            obj3.stat();
            methodgive baloon = new methodgive();
            baloon.namr();


        }
    }


    /// <summary>
    /// Arraylist and Dictionary
    /// </summary>


    public class arraylist
    { 
        public arraylist()
        { 
             ArrayList arrlist = new ArrayList();
            
             arrlist.Add("Welcome");
             arrlist.Add(100);
             arrlist.Add(20.5f);
             arrlist.Add("Tutlane");
             ArrayList arraylist2 = new ArrayList() { "raam", 34, 34.6, true };
             arrlist.AddRange(arraylist2);
             // check for an item 100 exists in arraylist or not
             foreach (var item in arrlist) 
             {
                 Console.WriteLine(item);
             }
            Console.WriteLine("\n====Using dictionary");

            Dictionary<string, string> cities = new Dictionary<string, string>()
             {
              {"UK", "London, Manchester, Birmingham"},
              {"USA", "Chicago, New York, Washington"},
              {"India", "Mumbai, New Delhi, Pune"}
             };
             Console.WriteLine(cities["UK"]);

             foreach (var kvp in cities)
             {
                 Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
             }
            Console.WriteLine("\n");
        }
    }


    /// <summary>
    /// Hashtable ,Try and catch function
    /// </summary>




    public class hashtabel
    {
        public void hash()
        {

            Hashtable htbl = new Hashtable();
            htbl.Add("msg", "Welcome");
            htbl.Add("site", "Tutlane");
            htbl.Add(1, 20.5f);
            htbl.Add(2, null);

            bool nam = (htbl[2] == null) ? true : false;

            Console.WriteLine("The key value 2 has null value:" + nam);

            var n = htbl[1];

            Console.WriteLine("\n"+"The index of hashtable 1 is :" + htbl["msg"] + n);
            // Another way to add elements. If key not exist, then that key adds a new key/value pair.
            htbl[3] = "Tutorials";
            // Add method will throws an exception if key already exists in hash table
            try
            {
                htbl.Add(4, 100);
            }
            catch
            {
                Console.WriteLine("An element with Key = '2' already exists.");

                Console.WriteLine("The index of hashtable 1 is :" + htbl["msg"]);

            }

            foreach (DictionaryEntry item in htbl)
            {
                Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
            }

        }
    }



    /// <summary>
    /// Queue-Enqueue , Dequeue, peek and adding array[] in queue
    /// </summary>


    public class queue
    {
        public queue(int a, string name)
        {
            Queue que = new Queue();
            que.Enqueue(a);
            que.Enqueue("I am queue");
            que.Enqueue("100.90");
            que.Enqueue(name);

            string msg = "Suresh,Rohini,Trishika,-Praveen%Sateesh";
            string[] strarr = msg.Split(new char[] { ',', '-', '%' }, StringSplitOptions.RemoveEmptyEntries);
            display(strarr);
            string[] arr = new string[3]{"malli","raj","ravi" };
            display(arr);
            
           

            //As in dexing is not in Queue forloop not working here
            /*for (int i = 0 ; i < que.Count; i++)
            {
                Console.WriteLine(que[i]);
            }*/

            /*foreach (var itm in que)   //previous method of me
            {
                if (itm == arr)
                { 
                    foreach(var ire in arr)
                    {
                        Console.WriteLine(ire);
                    }
                }
                Console.WriteLine("Enque in queue:"+itm);
            }

            */
            void display(string[] ar)
            {
                foreach (var itm in ar)
                {
                    que.Enqueue(itm);
                }
            }
            foreach (var itmm in que)
            {
                Console.WriteLine("Enque in queue:" + itmm);
            }
            while (que.Count > 10)
            {
               // var nem = que.Dequeue();

                Console.WriteLine("Deque the first 2 element:"+que.Dequeue());
            }
            Console.WriteLine("\n"+"The peek value after deque"+que.Peek());

        }

    }

    public class stackk
    {
        public void stat()
        {
            Stack stk = new Stack();
            stk.Push("welcome");
            stk.Push("to");
            stk.Push("stack");
            char[] charecter = new char[] { 'w', 'e', 'l', 'c', 'o', 'm', 'e' };
            diskk(charecter);
            void diskk(char[] cha)
            {
                foreach (var item in cha)
                {
                    stk.Push(item);
                }
            }
            foreach (var element in stk)
            {
                Console.WriteLine("\n" + element);
            }
            while (stk.Count > 5)
            {
                Console.WriteLine("\n"+stk.Pop());
            }
            foreach (var element in stk)
            {
                Console.WriteLine("Remaining in stack\n" + element);
            }

        }    
    }
    public class methodreusage
    {
        public string val;
        public string nameplus(string name2)
        {
            val = name2 + "kumar";
            return val;
        }
    }
    public class methodgive: methodreusage
    {
        public void namr()
        {
            string name2 = "pradeep";
            nameplus(name2);
            Console.WriteLine("\n"+val);
            
        }

    }
}
