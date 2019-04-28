using System;
using System.Collections.Generic;

namespace BST
{

    public class Node
    {
        public int Data;
        public Node LeftChild;
        public Node RightChild;
    }

    public class BinarySearchTree
    {
        public Node Root;

        public void add(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                Node current = Root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (data < current.Data)
                    {
                        current = current.LeftChild;
                        if(current == null)
                        {
                            parent.LeftChild = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.RightChild;
                        if (current == null)
                        {
                            parent.RightChild = newNode;
                            break;
                        }
                    }
                }
            }
        }

        public int maxDepth(Node node)
        {
            if (node == null)
                return 0;
            else
            {
                int lDepth = maxDepth(node.LeftChild);
                int rDepth = maxDepth(node.RightChild);

                if (lDepth > rDepth)
                    return (lDepth + 1);
                else
                    return (rDepth + 1);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.add(20);
            tree.add(30);
            tree.add(40);
            tree.add(50);
            tree.add(10);
            FindNode(tree.Root, 10);
            var x = tree.maxDepth(tree.Root);

        }

        public static int FindNode(Node node, int s)
        {
            var xx = 0;
            if (node == null)
                return 0;
            else if (s.CompareTo(node.Data) < 0)
                return (xx+1) ;
            else if (s.CompareTo(node.Data) > 0)
                return (xx + 1);

            return xx ;
            //var current = node;
            //Node parent;
            //var depth = 0;
            //while (true)
            //{
            //    parent = current;
            //    if (s == current.Data)
            //    {
            //        return "found" + depth;
            //    }
            //    else if(s < current.Data)
            //    {
            //        current = current.LeftChild;
            //        depth++;
            //    }
            //    else
            //    {
            //        current = current.RightChild;
            //        depth++;
            //    }
            //}
        }

    }
}
