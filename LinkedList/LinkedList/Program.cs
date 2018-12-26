using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
        public class Node
         {
           public int data;
           public Node next;
           internal class MyLinkedList
           {
               internal Node head;
           }
         }
        public class MyLinkedList
        {
            private Node head;
        public void PrintAllNodes()
            {
                Node current = head;
                int counter=1;
                while (current != null)
                {
                    Console.WriteLine("{0}.element: {1}", counter, current.data); counter++;
                    current = current.next;
                }
                
            }
            public void AddFirst(int _data)
            {
                Node New_Node = new Node();
                New_Node.data = _data;
                New_Node.next = head;
                head = New_Node;           
            }
            public void AddLast(int _data)
            {
                Node current=head;
                if (current == null)
                {
                    AddFirst(_data);
                }
                else
                {
                    while (current.next != null)
                    {
                        Node New_Node = new Node();
                        New_Node.data = _data;
                        current.next = New_Node;
                        New_Node.next = null;

                        current = current.next;
                    }
                }
            }
            public void AddAfter(int AdAf,int _data)
            {
                Node current = head;
                if (current == null) Console.WriteLine("no element to add after");
                else if (current.next == null) AddLast(_data);
                else
                {
                    Node prev=new Node();
                    while(prev.data!=AdAf && current!=null)
                    {

                    prev = current;
                    current = current.next;
                    }
                    if(prev ==null) Console.WriteLine(" the element cannot be founded in list");
                    else{
                    Node New_Node = new Node();
                    New_Node.data = _data;
                    New_Node.next = current;
                    prev.next = New_Node;
                    }
                }
            }
            public void AddBefor(int AdBef ,int _data)
            {
                Node current = head;
                if (current == null) Console.WriteLine("no element to add befor!!");
                else if (current.next == null) //there is one node so will be inserted as first.
                {
                    AddFirst(_data);
                }
                else
                {
                    int durum = 0;
                    Node prev = null; //previous node.
                    while (current.next !=null)
                    {
                        if (current.data == AdBef)
                        {
                            durum++;
                            break;
                        }
                        else
                        {
                            prev = current;
                            current = current.next;
                        }  
                    }
                    if (durum == 1) AddFirst(_data); //if the node at first.
                    else if (current.next == null) Console.WriteLine(" the element cannot be founded in list");
                    else
                    {
                        Node New_Node = new Node();
                        New_Node.data = _data;
                        New_Node.next = current;
                        prev.next = New_Node;
                    }
                }
            }
            internal void DeleteNodebyKey(int key)
            {
                Node current = head;
                if (current == null) Console.WriteLine("no element to remove");
                else
                {
                    int durum=0;
                    Node prev = new Node();
                    while (current != null)
                    {
                        if (current.data == key)
                        {
                            durum++;
                            break;
                        }
                        else
                        {
                            prev = current;
                            current = current.next;
                        }
                    }
                    if (current == null) Console.WriteLine("the element cann't be founded to remove it");
                    else if (durum == 1)//the node at first.
                    {
                        head = current.next;
                    }
                    else
                    {
                        prev.next = current.next; Console.WriteLine("the number {0} seccusfully removed",key);

                    }
                }
            }
            public void SearchData(int _data)
            {

                Node current = head;
                while (current != null)
                {
                    if (current.data == _data)
                    {
                        Console.WriteLine("the element founded: {0}", _data);
                        break;
                    }
                    else
                    {
                        current = current.next;
                    }
                }
                if (current == null)
                {
                    Console.WriteLine("the element that is searched for cann't be founded");
                }
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList MyList = new MyLinkedList();

            MyList.AddFirst(4);
            MyList.AddFirst(8);
            MyList.AddFirst(10);
            MyList.PrintAllNodes();

            Console.WriteLine("\t---*AddFirst*---");
            Console.Write("enter a number to insert first:");
            int num = int.Parse(Console.ReadLine());
            MyList.AddFirst(num);
            Console.WriteLine();
            MyList.PrintAllNodes();

           Console.WriteLine("\t---*AddAfter*---");
            Console.Write("enter a number that you want to insert after:");
            int AdAf = int.Parse(Console.ReadLine());
            Console.Write("\nenter a number:");
            int num1 = int.Parse(Console.ReadLine());
            MyList.AddAfter(AdAf, num1);
            Console.WriteLine();
            MyList.PrintAllNodes();

            Console.WriteLine("\t---*AddBefor*---");
            Console.Write("enter a number that you want to insert befor:");
            int AdBf = int.Parse(Console.ReadLine());
            Console.Write("\nenter a number:");
            int num2 = int.Parse(Console.ReadLine());
            MyList.AddBefor(AdBf, num2);
            Console.WriteLine();
            MyList.PrintAllNodes();

            Console.Write("enter a number to remove :");
            int rem =Convert.ToInt32(Console.ReadLine());
            MyList.DeleteNodebyKey(rem);
            Console.WriteLine();
            MyList.PrintAllNodes();
           
            Console.Write("enter a number to search for :");
           int  search = int.Parse(Console.ReadLine());
            MyList.SearchData(search);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
