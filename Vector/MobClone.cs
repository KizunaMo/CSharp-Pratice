using System;
using System.Collections.Generic;
using System.Text;

namespace Vector
{
    class MobClone
    {
        public int id = 0;
        public MobClone Clone()//這不是建構式 僅是一般的函式寫法，一定要回傳一個Mob類型的資料
        {
            return new MobClone()
            {
                id = id
            };
        }
    }
}
