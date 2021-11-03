using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public static class Swapper
    {
        public static void Swap<DT>(ref DT tpyeA ,ref DT typeB)
        {
            DT temporary = tpyeA;
            tpyeA = typeB;
            typeB = temporary;
        }
    }
}
