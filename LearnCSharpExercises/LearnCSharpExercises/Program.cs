using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharpExercises
{
    internal class Program
    {
        //No. 18 配列を入力値で初期化
        //要素数10の整数型の配列を宣言し、整数値を入力させ、すべての配列の要素を入力値として、すべての要素の値を表示するプログラムを作成せよ。

        //【実行例、下線部は入力例】
        //$ ./knock18
        //input number: 6
        //6
        //6
        //6
        //6
        //6
        //6
        //6
        //6
        //6
        //6
        //$

        static void Main(string[] args)
        {
            int num = 0;

            while (true)
            {
                Console.Write("input number: ");
                var val = Console.ReadLine();

                if (int.TryParse(val, out num) == false)
                {
                    Console.WriteLine("整数を入力してください。");
                    continue;
                }
                else
                {
                    break;
                }
            }

            int[] list = new int[10];

            // 繰り返しで初期値を代入する
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = num;
            }

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
