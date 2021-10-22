using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern_DesingnPattern
{
    class Youtube : IObserverable
    {
        List<IObserver> list = new List<IObserver>();
        /// <summary>
        /// 加入觀察者名單
        /// </summary>
        /// <param name="observer"></param>
        public void Add(IObserver observer)
        {
            this.list.Add(observer);
            Console.WriteLine("新增訂閱一名");
        }
        /// <summary>
        /// 移除觀察者名單
        /// </summary>
        /// <param name="observer"></param>
        public void Remove(IObserver observer)
        {
            this.list.Remove(observer);
            Console.WriteLine("取消訂閱一名");
        }
        /// <summary>
        /// 刷新狀態
        /// </summary>
        /// <param name="context"></param>
        public void NotifyObservers(string context)
        {
            foreach (IObserver observer in list)
            {
                observer.Update(context);
            }
        }

        /// <summary>
        /// 做出訂閱的動作
        /// </summary>
        /// <param name="observer"></param>
        public void Subscribe(IObserver observer)
        {
            Add(observer);
        }
        /// <summary>
        /// 取消訂閱的動作
        /// </summary>
        /// <param name="observer"></param>
        public void Unsubscribe(IObserver observer)
        {
            Remove(observer);
        }
        /// <summary>
        /// 發送訊息
        /// </summary>
        /// <param name="content"></param>
        public void SendMensange(string content)
        {
            Console.WriteLine($"發送消息...");
            NotifyObservers(content);
        }
    }
}
