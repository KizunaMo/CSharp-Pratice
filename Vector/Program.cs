using System;
using System.Numerics;

namespace VectorPractice
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //練習 向量計算
            Vector3 a;
            Vector3 b;

            Practice1();
            
            

        }

        static public void Practice1()
        {
            //假設知道單位圓夾角 求三角形一邊頂點座標(X,Y)
            //角度轉弧度var radian = (angle * Math.PI) / 180;
            Console.WriteLine($"輸入夾角");
            string cmd = Console.ReadLine();
            float cmdAngle;
            if (float.TryParse(cmd, out cmdAngle))
            {
                float radian = cmdAngle * MathF.PI / 180;
                Vector2 xy = new Vector2(MathF.Cos(radian),MathF.Sin(radian));
                Console.WriteLine($"單位圓XY座標{xy}\nX=cosΘ(長度){xy.X}\nY=sinΘ(長度){xy.Y}");
            }



        }
    }
}
