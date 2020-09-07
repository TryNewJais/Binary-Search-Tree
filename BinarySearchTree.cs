using System;
using System.Collections.Generic;
using System.Text;

namespace BST
{
    public class BinarySearchTree
    {
      public  Node root;

        public BinarySearchTree()
        {
            root = null;
        }
        public Node ReturnRoot()
        {

            return root;
        }

        public void insert(int i)
        {
            Node newNode = new Node(i);

            if (root == null)
            {
                root = newNode;
                return;
            }

            Node current = root;
            Node parent;
            while (true)
            {
                parent = current;
                if (current.id > i)
                {
                    current = current.leftNode;
                    if (current == null)
                    {
                        parent.leftNode = newNode;
                        return;
                    }

                }
                else
                {
                    current = current.rightNode;
                    if (current == null)
                    {
                        parent.rightNode = newNode;
                        return;
                    }

                }
            }
        }

        public Node InsertWithRecurrsion(Node root, int id)
        {
            if (root == null)
            {
                root = new Node(id);
            }
            else if (id < root.id)
            {
                root.leftNode = InsertWithRecurrsion(root.leftNode, id);
            }
            else
            {
                root.rightNode = InsertWithRecurrsion(root.rightNode, id);
            }
            return root;

        }


        public void Preorder(Node root)
        {
            if (root != null)
            {
                Console.Write(root.id + " ");
                Preorder(root.leftNode);
                Preorder(root.rightNode);
            }
        }
        public void Inorder(Node Root)
        {
            if (Root != null)
            {
                Inorder(Root.leftNode);
                Console.Write(Root.id + " ");
                Inorder(Root.rightNode);
            }
        }
        public void Postorder(Node Root)
        {
            if (Root != null)
            {
                Postorder(Root.leftNode);
                Postorder(Root.rightNode);
                Console.Write(Root.id + " ");
            }
        }

       
    }
    public class Node
    {
        public int id;
        public Node leftNode;
        public Node rightNode;
        public Node(int id)
        {
            this.id = id;
            leftNode = null;
            rightNode = null;
        }
        public void display()
        {
            Console.Write("[" + id + "]");
        }
    }
    
    
    
     class Program
    {
        static void Main(string[] args)
        {
           

            BinarySearchTree theTree = new BinarySearchTree();
            theTree.insert(20);
            theTree.insert(25);
            theTree.insert(45);
            theTree.insert(15);
            theTree.insert(67);
            theTree.insert(43);
            theTree.insert(80);
            theTree.insert(33);
            theTree.insert(67);
            theTree.insert(99);
            theTree.insert(91);
            Console.WriteLine("preorder Traversal : ");
            theTree.Preorder(theTree.ReturnRoot());
            Console.WriteLine();
            Console.WriteLine("postorder Traversal : ");
            theTree.Postorder(theTree.ReturnRoot());
            Console.WriteLine();
            Console.WriteLine("Inorder Traversal : ");
            theTree.Inorder(theTree.ReturnRoot());
            Console.WriteLine();


            Node node = null;
            BinarySearchTree theTree2 = new BinarySearchTree();
            node = theTree2.InsertWithRecurrsion(node, 20);
            node = theTree2.InsertWithRecurrsion(node, 25);
            node = theTree2.InsertWithRecurrsion(node, 45);
            node = theTree2.InsertWithRecurrsion(node, 15);
            node = theTree2.InsertWithRecurrsion(node, 67);
            node = theTree2.InsertWithRecurrsion(node, 43);
            node = theTree2.InsertWithRecurrsion(node, 80);
            node = theTree2.InsertWithRecurrsion(node, 33);
            node = theTree2.InsertWithRecurrsion(node, 67);
            node = theTree2.InsertWithRecurrsion(node, 99);
            node = theTree2.InsertWithRecurrsion(node, 91);
            Console.WriteLine("preorder Traversal : ");
            theTree2.Preorder(node);
           

            Console.ReadLine();
        }
}
