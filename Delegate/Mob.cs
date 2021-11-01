using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    class Mob
    {
        //用Lambda的寫法
        public Action talk { set; private get; }
        private int hp = 1;

        public void ToTalk()
        {
            talk();
        }

        public int SetHp(int hp)
        {
            this.hp = hp;
            return this.hp;
        }

        public int GetHp()
        {
            return hp;
        }




    }
}
