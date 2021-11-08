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
            list.push("WebDesign");
            list.push(".Net Developer");
            list.push("BackEnd developer");
            list.push("FullStack");
            list.push("Javascript and React");
            list.push("MS Sql server");
            list.push(2021);
            list.push(2020);
           
            list.print();
            list.peek();
           // file_write_Read.write_To_File(list);
            Console.ReadKey();

        }
    }
}
