using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class MyStack<DT>
    {
        MyLinkedList<DT> list = new MyLinkedList<DT>();

        public int Count => list.Count;
        /// <summary>
        /// 堆疊 把資料放進去
        /// </summary>
        /// <param name="data"></param>
        public void Push(DT data)
        {
            list.InsertFirst(data);
        }
        /// <summary>
        /// 堆疊 把資料拿出來(FILO)
        /// </summary>
        /// <returns></returns>
        public DT Pop()
        {
            var data = Peek();
            list.Remove(list.First());
            return data;
        }

        public bool TryPop(out DT data)
        {
            data = default;
            if (Count == 0) return false;
            data = list.First().data;
            return true;
        }
        /// <summary>
        /// 堆疊 把資料拿出來 (但是不刪除堆疊裡面的資料)
        /// </summary>
        /// <returns></returns>
        public DT Peek()
        {
            var node = list.First();
            if (node == null)
                throw new Exception();
            return node.data;
        }
    }
}
