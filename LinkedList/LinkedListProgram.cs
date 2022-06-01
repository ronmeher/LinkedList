using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedListProgram
    {
        internal Node head;
        internal void Add(int data)
        {
            Node n = new Node(data);
            if (this.head == null)
            {
                this.head = n;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = n;
            }
            Console.WriteLine($"{n.data} inserted into linked list");
        }


        internal Node DeleteFirstNode()
        {
            if (head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return head;

        }
        internal Node DeleteLastNode()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Node temp = head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;
            return head;
        }


        internal void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        internal Node Search(int data)
        {
            while (head != null)
            {
                if (head.data == data)
                {
                    return this.head;
                }
                this.head = this.head.next;

            }
            return null;
        }

        internal Node AddNodePartucularPositon(int data)
        {

            Node node = new Node(data);
            Node temp = head;
            Node previous = null;
            while (temp != null)
            {
                if (temp.data == 30)
                {
                    previous.next = node;
                    node.next = temp;
                    return previous;
                }
                previous = temp;
                temp = temp.next;

            }
            return null;
        }

        internal Node DeleteNode(int data)
        {
            Node temp = head;
            Node previous = null;
            while (temp != null)
            {
                if (temp.data == data)
                {
                    previous.next = temp.next;
                    Console.WriteLine("[" + data + "]  Node Deleted Successfully !!");
                    return previous;
                }
                previous = temp;
                temp = temp.next;
            }
            return null;
        }

        internal void AddDataAscendingOrder(int data)
        {
            Console.WriteLine("[" + data + "]" + "inserted in LinkedList");
            if(head == null)
            {
                head = new Node(data);
            }
            else if(data < head.data)
            {
                Node temp = new Node(data);
                temp.next = head;
                head = temp;
            }
            else
            {
                head.Sort(data);
            }


        }
    }

}
























