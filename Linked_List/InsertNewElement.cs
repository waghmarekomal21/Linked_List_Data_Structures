using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class InsertNewElement
    {
        Node head;

        public void Add(int newData)
        {
            Node newNode = new Node(newData);

            if (head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }

        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList list is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

        public void InsertElement(int data, int position)
        {
            Node newNode = new Node(data);
            newNode.data = data;
            newNode.next = null;

            if (position < 1)
            {
                Console.WriteLine("Position sholud be greater");
            }
            else if (position == 1)
            {
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                Node tempNode = new Node(data);
                tempNode = this.head;
                while (position > 2)
                {
                    tempNode = tempNode.next;
                    position--;
                }
                newNode.next = tempNode.next;
                tempNode.next = newNode;

            }
        }
    }
}