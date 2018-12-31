using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySeaechTree
{
    class Node
    {
        public int item;
        public Node leftc;
        public Node rightc;
        public void display(int data)
        {
            item = data;
            leftc = null;
            rightc = null;
        }
    }
    class Tree
    {
        public Node root;
        public Tree()
        {
            root = null;
        }
        public void print()
        {
            if (root == null) Console.WriteLine("emty");
        }
        public Node ReturnRoot()
        {
            return root;
        }
        public void insert(int id)
        {
            Node newNode = new Node();
            newNode.item = id;
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (id < current.item)
                    {
                        current = current.leftc;
                        if (current == null)
                        {
                            parent.leftc = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.rightc;
                        if (current == null)
                        {
                            parent.rightc = newNode;
                            return;
                        }
                    }
                }
            }
        }
    
        public void Search(int data)
        {
            Node current = root;
            if (root.item == data) Console.WriteLine("the number is founded : {0}", data);
            else
            {
                while (true)
                {
                    if (data < current.item)
                    {
                        current = current.leftc;
                        if (current.item == data)
                        {
                            Console.WriteLine("the number is founded in left side: {0}", data);
                            break;
                        }
                    }
                    else
                    {
                        current = current.rightc;
                        if (current.item == data)
                        {
                            Console.WriteLine("the number is founded : {0}", data);
                            break;
                        }
                    }
                }
            }
        }
        public void Preorder(Node Root)
        {
            if (Root != null)
            {
                Console.Write(Root.item + " ");
                Preorder(Root.leftc);
                Preorder(Root.rightc);
            }
        }
        public void Inorder(Node Root)
        {
            if (Root != null)
            {
                Inorder(Root.leftc);
                Console.Write(Root.item + " ");
                Inorder(Root.rightc);
            }
        }
        public void Postorder(Node Root)
        {
            if (Root != null)
            {
                Postorder(Root.leftc);
                Postorder(Root.rightc);
                Console.Write(Root.item + " ");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Tree MyTree = new Tree();
            MyTree.insert(20);
            MyTree.insert(13);
            MyTree.insert(5);
            MyTree.insert(27);
            MyTree.insert(25);

            Console.WriteLine("Inorder Traversal : ");
            MyTree.Inorder(MyTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Preorder Traversal : ");
            MyTree.Preorder(MyTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Postorder Traversal : ");
            MyTree.Postorder(MyTree.ReturnRoot());
            Console.WriteLine(" ");

            Console.Write("Enter a number to is searched: ");
            int search = int.Parse(Console.ReadLine());
            MyTree.Search(search);
            Console.ReadLine();
        }
    }
}
