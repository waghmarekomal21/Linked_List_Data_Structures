using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class SearchTheNode
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


        public void Searchnode(int value)
        {
            Node temp = this.head;
            if (temp != null)
            {
                while (temp != null)
                {
                    if (temp.data == value)
                    {
                        Console.WriteLine("{0} is present in the list", value);

                    }
                    temp = temp.next;
                }
            }
        }
    }
}