using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            for(int i=0;i<5;i++)
            {
                a1.Add(5);
                a1.Add("swathi");
                a1.Add(2.33);
                a1.Add('d');
                foreach (var val in a1)
                    Console.WriteLine(val);
                Queue qlist = new Queue();
                qlist.Enqueue(1);
                qlist.Enqueue("prudhivi");
                qlist.Enqueue('c');
                Console.WriteLine( qlist.Dequeue());
                foreach (var val in qlist)
                    Console.WriteLine(val);
                Stack slist = new Stack();
                slist.Push(23);
                slist.Push("hello");
                slist.Push(23.123);
                Console.WriteLine(slist.Pop());
                Console.WriteLine(slist.Peek());
                foreach (var s in slist) Console.WriteLine(s);
                Hashtable ht = new Hashtable();
                ht.Add(1, "CTS");
                ht.Add('a', 1000);
                ht.Add("t1", 30);
                foreach(var val in ht.Keys)
                {
                    Console.WriteLine(val);
                    Console.WriteLine(ht[val]);
                }
                List<int> list = new List<int>();
                list.Add(10);
                list.Add('a');
                list.Add(34);
                foreach (int val in list)
                    Console.WriteLine(val);
               
                HashSet<int> hs = new HashSet<int>();
                hs.Add(10);
                hs.Add(23);
                hs.Add(32);
                hs.Add(10);
                foreach (int val in hs)
                    Console.WriteLine(val);
                Console.WriteLine("##################");
                Queue<string> gqlist = new Queue<string>();
                gqlist.Enqueue("1");
                gqlist.Enqueue("swathi");
                gqlist.Enqueue("c");
                Console.WriteLine(gqlist.Dequeue());
                foreach (var val in gqlist)
                    Console.WriteLine(val);
                Stack<float> gslist = new Stack<float>();
                gslist.Push(23);
                gslist.Push(23.345f);
                gslist.Push(23.123f);
                Console.WriteLine(gslist.Pop());
                Console.WriteLine(gslist.Peek());
                foreach (var s in gslist) Console.WriteLine(s);
                Dictionary<int, string> dt = new Dictionary<int, string>();
                dt.Add(1, "swathi");
                dt.Add(2, "prudhivi");
                dt.Add(3, "divya");
                foreach(KeyValuePair<int,string> kl in dt)
                {
                    Console.WriteLine(kl.Key);
                    Console.WriteLine(kl.Value);
                }
                Console.ReadLine();
            }
        }
    }
}
