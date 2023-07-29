using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class LinkedListQueue
    {
        Node head = null;

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
                head = newNode;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            Console.WriteLine("{0} inserted into Queue", newNode.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }

        }
    }
}
