using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListProgram list = new LinkedListProgram();
            //list.Add(50);
            //list.Add(30);
            //list.Add(70);
            //list.AddNodePartucularPositon(40);
            //Console.WriteLine("Inserted 40 between 50 and 30 Successfully");
            //list.Display();

            //Console.WriteLine("\n\n");

            //list.DeleteNode(40);
            //list.Display();

            list.AddDataAscendingOrder(30);
            list.AddDataAscendingOrder(40);
            list.AddDataAscendingOrder(20);
            list.AddDataAscendingOrder(10);
            list.AddDataAscendingOrder(30);

            Console.WriteLine("\n  _______________  After Sorted in Ascending order_________________");
            list.Display();






            //Console.WriteLine("\n--------------- Deleted firt node ---------");
            //Node nodes = list.DeleteFirstNode();
            //list.Display();

            //Console.WriteLine("\n--------------- Deleted Last node ---------");
            //Node node = list.DeleteLastNode();
            //list.Display();





        }
    }
}
