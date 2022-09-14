using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DeleteTheLastElement
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

        public int DeleteLastNode()
        {
            Node newNode = this.head;
            if (this.head == null)
            {
                Console.WriteLine("Linked list is empty");
                return 0;
            }
            if (this.head.next == null)
            {
                return 0;
            }
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            int lastdeleteNode = newNode.next.data;
            newNode.next = null;
            return lastdeleteNode;

        }
    }
}