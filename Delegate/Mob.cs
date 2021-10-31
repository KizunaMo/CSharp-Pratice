using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    class Mob
    {
        //用Lambda的寫法
        public Action talk { set; private get; }

        public void ToTalk()
        {
            talk();
        }
    }
}
