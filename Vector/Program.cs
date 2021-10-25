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
            Practice2();
            

        }
        /// <summary>
        ///  1.假設知道單位圓夾角 求三角形一邊頂點座標(X,Y)
        ///  2.注意角度轉弧度的關係 ： var radian = (angle * Math.PI) / 180;  弧長算換角度radian→angle
        ///  3.一個圓的弧長是2π  radian表示佔據一個圓多少比例的弧長
        /// </summary>
        static public void Practice1()
        {
           
            Console.WriteLine($"輸入夾角");
            string cmd = Console.ReadLine();
            float cmdAngle;
            if (float.TryParse(cmd, out cmdAngle))
            {
                float radian = (cmdAngle * MathF.PI) / 180;
                Vector2 xy = new Vector2(MathF.Cos(radian),MathF.Sin(radian));
                Console.WriteLine($"單位圓XY座標{xy}\nX=cosΘ(長度){xy.X}\nY=sinΘ(長度){xy.Y}");
            }
        }
        /// <summary>
        /// 假設知道物件座標，求角度
        /// </summary>
        static public void Practice2()
        {
            Console.WriteLine($"輸入X座標");
            string vectorX = Console.ReadLine();
            Console.WriteLine($"輸入Y座標");
            string vectorY = Console.ReadLine();
            Vector2 cmdVector;
            if (float.TryParse(vectorX, out cmdVector.X) && float.TryParse(vectorY, out cmdVector.Y))
            {
                cmdVector = new Vector2(cmdVector.X, cmdVector.Y);
                float angle = (MathF.Acos(cmdVector.X) / MathF.PI) * 180;//cosΘ的反函數,反函數算出來的是弧長，求角度需要再將"弧長"換算成"角度"
                Console.WriteLine($"Θ角度={angle}");
                angle = (MathF.Asin(cmdVector.Y) / MathF.PI) * 180;//sinΘ的反函數 同樣都可以用來求Θ角度，注意對應的座標關係(X對cosΘ,Y對sinΘ)
                Console.WriteLine($"Θ角度={angle}");
            }
        }













    }
}
