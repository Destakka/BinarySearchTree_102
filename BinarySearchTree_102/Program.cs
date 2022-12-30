using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_102
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        //Constructor for the node class
        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }
    /*A nodde class consists os there things, the information, reference to the right child, and reference to the left child*/
    
    class BinaryTree
    {
        public Node ROOT;
        public BinaryTree()
        {
            ROOT = null; /*Initializing ROOt to null*/
        }
        public void insert(string element) /*Insert a node in the  binary search tree*/
        {
            Node tmp, parent = null, currentNode =  null;
            Search(element, ref parent, ref currentNode);
            if (currentNode == null) /*Check if the node to be inserted already inserted or not*/
            {
                Console.WriteLine("Duplicate words not allowed");
                return;
            }
            else /*if the spesified node is not present*/
            {
                tmp = new Node(element, null, null); /*Creates a Node*/
                if (parent ==  null) /*If the trees is empty*/
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element, parent.info) < 0)
                {
                    parent.leftchild = tmp;
                }
                else
                {
                    parent.rightchild = tmp;
                }
            }
        }
        public void Search (string element, ref Node parent, ref Node currentNode)
        {
            /*This function searches the currentNode of the specified Node as well as the current Node of its parent */
            currentNode = ROOT;
            parent = null;
            while ((currentNode != null) && (currentNode.info != element))
            {
                parent = currentNode;
                if (string.Compare(element, currentNode.info) < 0)
                    currentNode = currentNode.leftchild;
                else
                    currentNode = currentNode.rightchild;
            }
        }
        public void Inorder(Node ptr)
        {
            if(ROOT == null)
            {
                Console.WriteLine("Tree is empty");
            return ;
            }
            if (ptr != null)
            {
                Inorder(ptr.leftchild);
                Console.Write(ptr.info + "");
                Inorder(ptr.rightchild);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
