﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace StackTest
{
    class Write_To_File
    {
        public StackList myList;
       public Write_To_File(StackList mylist)
        {
            myList = mylist;
        }

        public void write_To_File(StackList stack)
        {
            FileInfo fi = new FileInfo(@"F:\C#\FileBank\DummyFile.txt");

            //Open file for Read\Write
            FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);

            //Create StreamWriter object to write string to FileSream
            StreamWriter sw = new StreamWriter(fs);
            Node temp =stack.top;
            sw.WriteLine("--------------------------------");
            while (temp != null)
            {
                sw.WriteLine(temp.data);
                // File.WriteAllText(@"F:\C#\FileBank\DummyFile.txt", temp.data);
                temp = temp.link;
            }
            sw.WriteLine("--------------------------------");
            sw.WriteLine();
            sw.WriteLine($"Number of elementds in the stack is {stack.length} ");
            sw.WriteLine($"The top element is {stack.top.data}");
            sw.Close();
        }
    }
}
