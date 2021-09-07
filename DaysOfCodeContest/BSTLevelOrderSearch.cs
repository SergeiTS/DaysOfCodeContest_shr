using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
    class BSTLevelOrderSearch
    {
        public static void levelOrder(Node2 root)
        {
            Queue<Node2> queue = new Queue<Node2>();
            queue.Enqueue(root);
            while ( queue.Count != 0 )
            {

                Node2 tempNode = queue.Dequeue();
                Console.Write(tempNode.data + " ");

                if ( tempNode.left != null )
                {
                    queue.Enqueue(tempNode.left);
                }

                if ( tempNode.right != null )
                {
                    queue.Enqueue(tempNode.right);
                }
            }
        }
        public static Node2 insert(Node2 root, int data)
        {
            if ( root == null )
            {
                return new Node2(data);
            }
            else
            {
                Node2 cur;
                if ( data <= root.data )
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
    }
    class Node2
    {
        public Node2 left, right;
        public int data;
        public Node2(int data)
        {
            this.data = data;
            left = right = null;
        }
    }
}
