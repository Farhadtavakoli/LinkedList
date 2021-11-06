using System;

namespace LinkedList2
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList myList = new LinkedList(); // It creates the first node.
            myList.insertEnd("Yasin");
            myList.insertEnd("Tavakoli");
            myList.insertEnd("Myfuture");
            myList.insertEnd("Mydream");
            myList.insertEnd("Farhad");
            myList.insertEnd("Jina");
            myList.printList();
          
          
            Node lastNode = myList.getLastNode(myList);
            Console.Write($"This list has {myList.length} node(s) ---->");
            myList.printList();

            Console.WriteLine($"Fisrt node is {myList.head.next.data}");
            Console.WriteLine($"Last node id {lastNode.data} ");
            
            Console.WriteLine($"*********The fisrt node is deleted******************");
            myList.printList();
            myList.removeFirst(myList);
            myList.printList();
            Console.WriteLine("*****************************************************");
            if(myList.)
          
            Console.WriteLine($"*********The last node is deleted******************");
            myList.printList();
            myList.removeLast(myList);
            myList.printList();
            Console.WriteLine("*****************************************************");

            myList.insertEnd("Hello");
            myList.printList();
            myList.removeLast(myList);
            myList.printList();
            myList.removeFirst(myList);
            myList.printList();
            myList.removeData(myList, "Myfuture");
            myList.printList();
            Console.ReadKey();


        }
    }
}
