using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList2
{
    class LinkedList
    {
        public Node currentNode;
        public Node head;
        public int length;
        public LinkedList()
        {
            head = new Node();
            currentNode = head;
        }
        public void insertEnd(object data)
        {
            if (data != null)
            {
                Node newNode = new Node(data);
                currentNode.next = newNode;
                currentNode = newNode;
                length++;
            }
        }
        public void printList()
        {
            Node current = head;
            while (current.next != null)
            {
                    current = current.next;
                    Console.Write($"{current.data} ");
            }
            Console.WriteLine();
        }
        public void removeData(LinkedList myList,object data)
        {
            Node tempNode =myList.head;
            Node prevNode = null;
            if(tempNode!=null&& tempNode.data==data)
            {
                myList.head = tempNode.next;
                return;
            }
            while (tempNode!=null&& tempNode.data != data)
            {
                prevNode = tempNode;
                tempNode = tempNode.next;
            }
            if (tempNode == null)
            {
                return;
            }
            prevNode.next = tempNode.next;
                    length--;

        }

        public void removeFirst(LinkedList myList)
        {
            if (length>0)
            {
                myList.head = myList.head.next;
             
                length--;
            }
            else
                Console.WriteLine("The list is empty");
        }
        //public void removeLast(LinkedList myList)
        //{
        //    Node current = head, last = current;

        //    if (myList.head == null) return;
        //    if (myList.head.next == null)
        //    {
        //        head = null;
        //        return;
        //    }

        //    while (current.next != null)
        //    {
        //        last = current;
        //        current = current.next;

        //    }
        //    last.next = null;

        //}

        public Node getLastNode(LinkedList myList)
        {
            Node lastNode = myList.head;
            while (lastNode.next != null)
            {
                lastNode = lastNode.next;
            }
          //  lastNode.next = null;
            
            return lastNode;
        }

        public void removeLast(LinkedList myList)
        {
            Node lastNode = myList.getLastNode(myList);
            lastNode.data = null;
        }
    }
}
