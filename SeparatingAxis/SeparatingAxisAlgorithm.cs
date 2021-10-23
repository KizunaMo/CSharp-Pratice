using System;
using System.Collections.Generic;
using System.Text;

namespace SeparatingAxis
{
    class SeparatingAxisAlgorithm
    {
        ///// <summary>
        ///// 解(偵測)有沒有碰撞，但需要先建構好資料類型，修改下面演算法對應的位置
        ///// </summary>
        ///// <param name="C0"></param>
        ///// <param name="C1"></param>
        ///// <returns></returns>
        //Bool TestIntersect(ConvexPolyhedron C0, ConvexPolyhedron C1)
        //{
        //    // test faces of C0 for separation
        //    for (i = 0; i < C0.GetFaceCount(); i++)
        //    {
        //        D = C0.GetNormal(i);
        //        ComputeInterval(C0, D, min0, max0);
        //        ComputeInterval(C1, D, min1, max1);
        //        if (max1 < min0 || max0 < min1) return false;
        //    }
        //    // test faces of C1 for separation
        //    for (i = 0; i < C1.GetFaceCount(); i++)
        //    {
        //        D = C1.GetNormal(i);
        //        ComputeInterval(C0, D, min0, max0);
        //        ComputeInterval(C1, D, min1, max1);
        //        if (max1 < min0 || max0 < min1) return false;
        //    }

        //    // test cross products of pairs of edges
        //    for (i = 0; i < C0.GetEdgeCount(); i++)
        //    {
        //        for (j = 0; j < C1.GetEdgeCount(); j++)
        //        {
        //            D = Cross(C0.GetEdge(i), C1.GetEdge(j));
        //            ComputeInterval(C0, D, min0, max0);
        //            ComputeInterval(C1, D, min1, max1);
        //            if (max1 < min0 || max0 < min1) return false;
        //        }
        //    }
        //    return true;
        //}

        //void ComputeInterval(ConvexPolyhedron C, Vector D,
        //                          double &min, double &max)
        //{
        //    min = Dot(D, C.GetVertex(0));
        //    max = min;
        //    for (i = 1; i < C.GetVertexCount(); i++)
        //    {
        //        value = Dot(D, C.GetVertex(i));
        //        if (value < min) min = value;
        //        else if (value > max) max = value;
        //    }
        //}
    }
}
