using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayListMethod();
            //StackMethod();
            //QueneMethod();
            HashTableMethod();
            Console.ReadKey();
        }
        static void ArrayListMethod()
        {
            Int32[] values;
            values = new Int32[4];
            for (int a = 0; a < 4; a++)
            {
                values[a] = a;
            }
            ArrayList a1 = new ArrayList();
            a1.Add(1);
            a1.Add("second");
            a1.Add(true);
            a1.Add(values);
            for (int a = 0; a < a1.Count; a++)
            {
                Console.WriteLine(a1[a]);
            }
            Console.WriteLine("\nRemove 4th element in ArrayList\n");
            a1.Remove(a1[3]);
            for (int a = 0; a < a1.Count; a++)
            {
                Console.WriteLine(a1[a]);
            }
        }
        static void StackMethod()
        {
            Stack st = new Stack();
            st.Push(1);
            st.Push(true);
            st.Push("third");

            foreach (Object obj in st)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine($"No of element in the stack = {st.Count}");
            Console.WriteLine($"Does the Stack contains element 1: {st.Contains(1)}");
            st.Pop();
            foreach (Object obj in st)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("\nWriteLine before Clear");
            st.Clear();
            foreach (Object obj in st)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("WriteLine after Clear");
        }
        static void QueneMethod()
        {
            Queue qu = new Queue();
            qu.Enqueue(1);
            qu.Enqueue(true);
            qu.Enqueue("third");
            foreach (Object obj in qu)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine($"No of element in the Queue = {qu.Count}");
            Console.WriteLine($"Does the Queue contains element 1: {qu.Contains(1)}");
            Console.WriteLine("\nWriteLine before Dequeue");
            qu.Dequeue();
            foreach (Object obj in qu)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("\nWriteLine before Clear");
            qu.Clear();
            foreach (Object obj in qu)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("WriteLine after Clear");
        }
        static void HashTableMethod()
        {
            Hashtable openWith = new Hashtable();
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");
            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }
            foreach (DictionaryEntry de in openWith)
            {   
                Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
            }
            Console.WriteLine("\nRemove(\"doc\")");
            openWith.Remove("doc");

            if (!openWith.ContainsKey("doc"))
            {
                Console.WriteLine("Key \"doc\" is not found.");
            }
            Console.WriteLine("\nRemove(\"bmp\")");
            openWith.Remove("bmp");

            if (!openWith.ContainsKey("bmp"))
            {
                Console.WriteLine("Key \"bmp\" is not found.\n  ");
            }

            foreach (DictionaryEntry de in openWith)
            {
                Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
            }
        }
    }
}