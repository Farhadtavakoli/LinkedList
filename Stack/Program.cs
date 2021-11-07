using System;
using System.Collections;

namespace StackTest
{
    class Program
    {
        static void Main(string[] args)
        {
            StackList list = new StackList();
            list.push("Tavakoli");
            list.push("Farhad");
            list.push("Yasín");
            list.push("Farhad");
            list.push("Baba");

             list.print();
            Console.WriteLine($"The head element is {list.peek()}");
            Console.ReadKey();
        }
    }
}
