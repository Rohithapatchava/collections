using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;

namespace collections
{
    class Program
    {
       
        static void Main(string[] args)
        {
            List<string> stlst = new List<string>();
            stlst.Add("programming languages");
            stlst.Add("C sharp");
            stlst.Add("vb");
            stlst.Add("java");
            stlst.Add("javascript");
            foreach(string i in stlst)
            {
                Console.WriteLine(i);
            }
            //sortedlist();
            //Queue();

            //stack();
            //Hashtble();
            //Arralist();

        }

        private static void sortedlist()
        {
            SortedList slist = new SortedList();
            slist.Add("Zameer", 234);
            slist.Add("karan", 123);
            slist.Add("krish", 124);
            slist.Add("mahi", 294);
            foreach (string k in slist.Keys)
            {
                Console.WriteLine(k);
            }
            foreach (int k in slist.Values)
            {
                Console.WriteLine(k);
            }
        }

        private static void Queue()
        {
            Queue q = new Queue();
            q.Enqueue(123);
            q.Enqueue(124);
            q.Enqueue(127);
            foreach (int i in q)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            q.Dequeue();
            foreach (int i in q)
            {
                Console.WriteLine(i);
            }
        }

        private static void stack()
        {
            Stack stk = new Stack();
            stk.Push("chocolate");
            stk.Push("biscuit");
            stk.Push("cake");
            stk.Push("coke");
            foreach (string h in stk)
            {
                Console.WriteLine(h);

            }
            stk.Pop();
            foreach (string h in stk)
            {
                Console.WriteLine(h);

            }
        }

        private static void Arralist()
        {
            ArrayList a1 = new ArrayList() { "Rohitha", "akhila", "vignitha", "padmapriya" };
            a1.Sort();
            foreach (string a in a1)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            a1.Add("akhila B");
            foreach (string a in a1)
            {
                Console.WriteLine(a);

            }
            Console.WriteLine();
            string[] r = new string[] { "cat", "dog" };
            a1.SetRange(2, r);
            foreach (string a in a1)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            a1.Remove("cat");
            foreach (string a in a1)
            {
                Console.WriteLine(a);
            }
        }

        private static void Hashtble()
        {
     

        Hashtable hst = new Hashtable();
            hst.Add("raju", "123");
            hst.Add("vimala", "124");
            hst.Add("kiran", "127");
            hst.Add("mahesh", "129");
            foreach (string h in hst.Keys)
            {
                Console.WriteLine(h);
            }
            foreach (string h in hst.Values)
            {
                Console.WriteLine(h);
            }
        }
    }

}


