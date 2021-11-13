using Algorithms;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class ReSourcePool
    {

        //資源池練習 (用節點操作)
        MyLinkedList<Mob> used = new MyLinkedList<Mob>();
        MyLinkedList<Mob> free = new MyLinkedList<Mob>();

        Mob mob = new Mob();

        public void Recycle(MyLinkedList<Mob>.Node node)
        {
            used.Remove(node);
            free.InsertFirst(mob);
        }

        public MyLinkedList<Mob>.Node NewMonster()
        {
            var tmp = free.First();
            if (tmp == null)
            {
                Mob mob = new Mob();
                free.InsertFirst(mob);
                tmp = free.First();
            }
            return tmp;
        }
    }
}
