using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class TreeNode
    {
        private int data;

        public int Data { get { return data; } }

        private TreeNode rightNode;
        public TreeNode RightNode { get { return rightNode; } set { rightNode = value; } }

        private TreeNode leftNode;
        public TreeNode LeftNode { get { return leftNode; } set { leftNode = value; } }

        private bool isDeleted;
        public bool IsDeleted { get { return isDeleted; } }

        public TreeNode(int data)
        {
            this.data = data;
        }
        public void Delete()
        {
            isDeleted = true;
        }

        public TreeNode Find(int value)
        {
            TreeNode currentNode = this;

            while (currentNode != null)
            {
                if (value == currentNode.data && isDeleted == false)
                {
                    return currentNode;
                }
                else if (value > currentNode.data)
                {
                    currentNode = currentNode.rightNode;
                }
                else
                {
                    currentNode = currentNode.leftNode;
                }
            }
            return null;//Node沒找到
        }

        public TreeNode FindRecursive(int value)
        {
            if (value == data && isDeleted == false)
            {
                return this;
            }
            else if (value < data && leftNode != null)
            {
                return leftNode.FindRecursive(value);
            }
            else if (value > data && rightNode != null)
            {
                return rightNode.FindRecursive(value);
            }
            else
            {
                return null;
            }
        }

        public void Insert(int value)
        {
            if (value >= data)
            {
                if (rightNode == null)
                    rightNode = new TreeNode(value);
                else
                    rightNode.Insert(value);
            }
            else
            {
                if (leftNode == null)
                    leftNode = new TreeNode(value);
                else
                    leftNode.Insert(value);
            }
        }
    }
}

