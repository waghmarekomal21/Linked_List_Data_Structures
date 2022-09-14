using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DeleteTheFirstElement
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
        public int DeleteFirstNode()
        {
            if (this.head == null)
            {
                Console.WriteLine("Linked list is empty");
                return 0;
            }
            int deleteNode = this.head.data;
            this.head = this.head.next;
            return deleteNode;

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
    }
}