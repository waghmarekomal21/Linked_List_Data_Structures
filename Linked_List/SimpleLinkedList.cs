using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class SimpleLinkedList
    {
        Node head;
        public void Simple(int newData)
        {
            Node newNode=new Node(newData);

            if(this.head==null)
            {
                this.head=newNode;
            }
            else
            {
                Node temp = head;
                while(temp.next!=null)
                {
                    temp=temp.next;
                }
                temp.next=newNode;
            }

        }
        public void Display()
        {
            Node temp = this.head;
            if(temp==null)
            {
                Console.WriteLine("LinkedList Is Empty");
            }
            while(temp!=null)
            {
                Console.WriteLine(temp.data);
                temp=temp.next;
            }
        }

    }
}
