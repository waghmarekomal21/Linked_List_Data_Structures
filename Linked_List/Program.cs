namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option.\n1.Simple Linked List.\n2.Add Element \n4.Ability to Insert in between.\n5.Delete the First Element in the Linked List.\n6.Delete the Last Element in the Linked List.\n7.Search Node 30.\n8.Insert 40 After 30 in Linked List");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch(option)
            {
                 case 1:
                    SimpleLinkedList simpleLinkedList = new SimpleLinkedList();
                    simpleLinkedList.Simple(56);
                    simpleLinkedList.Simple(30);
                    simpleLinkedList.Simple(70);
                    simpleLinkedList.Display();
                 break;
                case 2:
                    AddElement add = new AddElement();
                    add.Add(56);
                    add.InsertElement1(30,2);
                    add.InsertElement2(70,3);
                    add.Display();
                    break;
                case 4:
                    InsertInBetweenLinkedList between = new InsertInBetweenLinkedList();
                    between.Add(56);
                    between.Add(70);
                    between.InsertBetween(30, 2);
                    between.Display();
                break;
                default:
                case 5:
                    DeleteTheFirstElement deletefirst = new DeleteTheFirstElement();
                    deletefirst.Add(56);
                    deletefirst.Add(30);
                    deletefirst.Add(70);
                    Console.WriteLine("{0} is a Deleted in the Linked List ", deletefirst.DeleteFirstNode());
                    Console.WriteLine("Element in linked list are ");
                    deletefirst.Display();
                break;
                case 6:
                    DeleteTheLastElement deletelast = new DeleteTheLastElement();
                    deletelast.Add(56);
                    deletelast.Add(30);
                    deletelast.Add(70);
                    Console.WriteLine("{0} is a Deleted in the Linked List ", deletelast.DeleteLastNode());
                    Console.WriteLine("Element in Linked List are ");
                    deletelast.Display();
                    break;
                case 7:
                    SearchTheNode search = new SearchTheNode();
                    search.Add(56);
                    search.Add(30);
                    search.Add(70);
                    search.Searchnode(30);
                    break;
                case 8:
                    InsertNewElement insertnewelement = new InsertNewElement();
                    insertnewelement.Add(56);
                    insertnewelement.Add(30);
                    insertnewelement.Add(70);
                    insertnewelement.InsertElement(40, 3);
                    insertnewelement.Display();
                    break;

                    Console.WriteLine("Invalid Option");
                    break;
           }
       }
    }
}