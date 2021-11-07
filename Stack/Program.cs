using System;
using System.Collections;

namespace StackTest
{
    class Program
    {
        static void Main(string[] args)
        {
            StackList list = new StackList();
            //list.push("Tavakoli");
            //list.push("Farhad");
            list.push("Yasín");
           
           // list.print();
            list.peek(list);
          //  Console.WriteLine(list.top.data);
            Console.ReadKey();
        }
    }
}
