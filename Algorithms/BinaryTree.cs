using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class BinaryTree
    {
        private TreeNode root;

        //public TreeNode Find(int data)
        //{

        //}
        //public TreeNode FindRecursive(int data)
        //{

        //}

        public void Insert(int data)
        {
            if (root != null)
                root.Insert(data);
            else
                root = new TreeNode(data);
        }



    }







}
