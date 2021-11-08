using System;

namespace LinkedList2
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList myList = new LinkedList(); // It creates the first node.
            myList.insertEnd("Java");
            myList.insertEnd("C++");
            myList.insertEnd("FoxPro :)");
            myList.insertEnd("Javascript");
            myList.insertEnd("Python");
            myList.insertEnd("C");
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
