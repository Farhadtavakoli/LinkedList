using System;
using System.Collections.Generic;
using System.Text;

namespace StackTest
{
    public class StackList
    {
        public Node top;
        public int length;
        public StackList()
        {
            this.top = null;
        }

        public void push(object data)
        {
            // Checks if the stack is full
            Node temp = new Node();
            if (temp == null)
            {
                Console.WriteLine("The stack is full!");
                return;

            }
            length++;
            temp.data = data; // Putting data into  temp field
            temp.link = top; // Put top reference into temp link
            top = temp; // update top reference
        }

        public bool isEmpty()
        {
            return top == null; // If it is empty
        }

        /// <summary>
        /// It returns the top element of the list
        /// </summary>
        /// <returns></returns>
        public object peek()
        {
            if (!isEmpty())
            {
                return top.data;
            }
            else
            {
                Console.WriteLine("The list is empty");
                return -1; // -1 is out of range and means no data
            }
        }

        public void pop()
        {
            if (top == null)
            {
                Console.WriteLine("No data! The list is empty");
                return;
            }
            length--;
            top = top.link; // The top pointer points to the next element in the list 
        }

        public void print()
        {
            if (top == null)
            {
                Console.WriteLine("The list is empy");
                return;
            }
            else
            {
                Console.WriteLine("------------");
                Node temp = top;
                while (temp != null)
                {
                   Console.WriteLine($"{temp.data} ");
                   temp = temp.link;
                }
                Console.WriteLine();
                Console.WriteLine($"------{length} item(s)-----");
            }
        }


    }
}
