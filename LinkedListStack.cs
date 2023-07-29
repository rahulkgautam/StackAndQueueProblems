using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    public class LinkedListStack
    {
        private Node top;
        public LinkedListStack()
        {
            this.top = null;
        }
        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (this.top == null)
                newNode.next = null;
            else
                newNode.next = this.top;
            this.top = newNode;
            Console.WriteLine("{0} pushed to stack ", data);
        }
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine("{0} is in the top of the stack", this.top.data);
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty,Deletion is not possible");
                return;
            }
            Console.WriteLine("Value Poped is {0}", this.top.data);
            this.top = this.top.next;
        }
        public void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
