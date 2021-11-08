using System;
using System.Collections;

namespace StackTest
{
    class Program
    {
        static void Main(string[] args)
        {
            StackList list = new StackList();
            Write_To_File file_write_Read = new Write_To_File(list);
            list.push("Tavakoli");
            list.push("Farhad");
            list.push("Yasín");
            list.push("Farhad");
            list.push("Baba");
            list.push("Fullstack developer");
            list.push("Javascript");
            list.push("Roya");
           
            list.print();
            list.peek();
            list.peek();
            file_write_Read.write_To_File(list);
            Console.ReadKey();

        }
    }
}
