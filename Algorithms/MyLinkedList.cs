using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class MyLinkedList<DT>
    {
        public class Node
        {
            public DT data;
            internal Node prevNode;
            internal Node nextNode;
            internal Node()//利用internal配合建構式；來禁止外部new，保護架構
            {
            }
        }

        Node root;
        Node tail;

        public MyLinkedList()
        {
            root = new Node();
            tail = new Node();
            root.nextNode = tail;
            tail.prevNode = root;
        }

        public Node Find(Func<DT, bool> finder)
        {
            Node node = root.nextNode;
            while (root != tail)
            {
                if (finder(node.data) == true)
                    return node;
                else
                    node = node.nextNode;
            }
            return null;
        }
        /// <summary>
        /// 加入一筆資料(新節點)在節點的後面
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node InsertAfter(Node node, DT value)
        {
            if (node == null)
                throw new Exception("不可以是null");
            var newNode = new Node() { data = value };
            var parent = node;
            var child = node.nextNode;
            newNode.prevNode = parent;
            newNode.nextNode = child;
            parent.nextNode = newNode;
            child.prevNode = newNode;

            //newNode.prevNode = node;
            //newNode.nextNode = node.nextNode;
            //node.nextNode = newNode;
            //newNode.nextNode.prevNode = newNode;

            return newNode;
        }
        /// <summary>
        /// 加入一筆資料(新節點)加進某個節點的前面
        /// </summary>
        /// <param name="node"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public Node InsertBefore(Node node, DT data)
        {
            return InsertAfter(node.prevNode, data);
        }
        /// <summary>
        /// 加入一筆資料(新節點) 放在最後面
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public Node Append(DT data)
        {
            return InsertBefore(tail, data);
        }

        public Node InsertFirst(DT data)
        {
            return InsertAfter(root, data);
        }

        public Node Remove(Node node)
        {
            var parent = node.prevNode;
            var child = node.nextNode;
            parent.nextNode = child;
            child.prevNode = parent;

            return node;
        }

        public Node First()
        {
            Node n = root.nextNode;
            return n == tail ? null : n;
        }
    }
}
