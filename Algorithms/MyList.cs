using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class MyList<DT>
    {
        DT[] data = new DT[100];//練習 增刪讀寫找
        public int Count { private set; get; } = 0;

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= Count) throw new Exception($"超過範圍 0<x<{index}");
        }
        /// <summary>
        /// 讀&&寫
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public DT this[int index]
        {
            set//寫
            {
                ValidateIndex(index);
                data[index] = value;
            }
            get//讀
            {
                ValidateIndex(index);
                return data[index];
            }
        }
        /// <summary>
        /// 查找
        /// </summary>
        /// <param name="finder">提供要找的對象</param>
        /// <returns></returns>
        public int Find(Func<DT, bool> finder)
        {
            for (int i = 0; i < Count; i++)
            {
                if (finder(data[i]) == true)
                    return i;
            }
            return -1;
        }
        /// <summary>
        /// 刪除
        /// </summary>
        /// <param name="index"></param>
        public void Remove(int index)
        {
            ValidateIndex(index);
            for (int i=index; i< Count; i++)
            {
                data[i] = data[i + 1];//每個資料往前移
            }
            Count--;
        }
        /// <summary>
        /// 加在最後面
        /// </summary>
        /// <param name="value"></param>
        /// <param name="addMemory">如果當記憶體不夠時，可多配置進去的記憶體大小</param>
        public void Add(DT value,int addMemory)
        {
            //ReconfigureMemory(addMemory);
            //data[Count] = value;
            //Count++;
            Insert(Count, value, addMemory);
        }
        /// <summary>
        /// 加入在某個位置
        /// </summary>
        /// <param name="index">加在哪一個位置</param>
        /// <param name="value">值是多少</param>
        /// <param name="addMemory">如果當記憶體不夠時，可多配置進去的記憶體大小</param>
        public void Insert(int index ,DT value, int addMemory)
        {
            if (index < 0 || index > Count) throw new Exception($"超過範圍 0<x<={Count}");
            ReconfigureMemory(addMemory);
            for (int i = Count; i >index; i--)
            {
                data[i] = data[i-1];
            }

            data[index] = value;
            Count++;
        }

        public void PrintList()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.Write($"{data[i]}  ");
            }
            Console.WriteLine($"\n");
        }


        private void ReconfigureMemory(int value)
        {
            if (Count >= data.Length)//如果記憶體不足，需要重新配置記憶體
            {
                DT[] tmp = new DT[data.Length + value];//多配置一點
                for (int i = 0; i < data.Length; i++)
                {
                    tmp[i] = data[i];
                }
                data = tmp;
                //Array.Resize(ref data, data.Length + value);內建的方法 同63-68
            }
        }
    }
}
