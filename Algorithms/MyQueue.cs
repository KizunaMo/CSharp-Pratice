using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class MyQueue<DT>
    {
        MyLinkedList<DT> list = new MyLinkedList<DT>();

        public void EnQueue(DT data)
        {
            list.Append(data);
        }

        public DT DeQueue()
        {
            var node = list.First();
            if (node == null)
                throw new Exception();
            return node.data;
        }

    }
}
