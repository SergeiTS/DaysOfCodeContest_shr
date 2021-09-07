using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
    class BST
    {
        public static NodeL Insert(NodeL root, int data)
        {
            if ( root == null )
            {
                return new NodeL(data);
            }
            else
            {
                NodeL cur;
                if ( data <= root.data )
                {
                    cur = Insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = Insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
        public static int GetHeight(NodeL root)
        {
            if ( root == null )
                return -1;
            else
            {
                int lDepth = GetHeight(root.left);
                int rDepth = GetHeight(root.right);

                if ( lDepth > rDepth )
                    return (lDepth + 1);
                else
                    return (rDepth + 1);
            }
        }
    }
    class NodeL
    {
        public NodeL left, right;
        public int data;
        public NodeL(int data)
        {
            this.data = data;
            left = right = null;
        }
    }
}
