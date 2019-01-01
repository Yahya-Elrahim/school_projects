using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Mini_InBST
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;
        public void display(int _data)
        {
            this.data = _data;
            this.left = null;
            this.right = null;
        }
    }
    public class BST
    {
        public Node root;
        public BST()
        {
            root = null;
        }
        public void insert(int id)
        {
            Node newNode = new Node();
            newNode.data = id;
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (id < current.data)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            return;
                        }
                    }
                }
            }
        }
        public Node ReturnRoot()
        {
            return root;
        }
        public void Preorder(Node Root)
        {
            if (Root != null)
            {
                Console.Write(Root.data + " ");
                Preorder(Root.left);
                Preorder(Root.right);
            }
        }
        public void FindMaxMinNodes()
        {
            Node current = root;
            if (root == null) Console.WriteLine("tree is empty.");
            else
            {
                    {
                        current = current.left;
                    }
                    Console.WriteLine("minimum value in tree is: {0}", current.data);

                    current = root;
                    while (current.right != null)
                    {
                        current = current.right;
                    }
                    Console.WriteLine("maximum value in tree is: {0}", current.data);
                
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BST MyTree = new BST();
            
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                MyTree.insert(rnd.Next(1, 50));
            }
            MyTree.Preorder(MyTree.ReturnRoot());

            Console.WriteLine("\n");
                MyTree.FindMaxMinNodes();
            Console.Read();
        }
    }
}
