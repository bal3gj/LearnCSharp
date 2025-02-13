using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharpExercises
{
    internal class Program
    {

        //No. 17 配列を初期化
        //要素数10の整数型の配列を宣言し、i番目の要素の初期値をiとし、順に値を表示するプログラムを作成せよ。

        //【実行例、下線部は入力例】
        //$ ./knock17
        //0
        //1
        //2
        //3
        //4
        //5
        //6
        //7
        //8
        //9
        //$
        //配列の初期化は初期化子を使ってもよいし、繰り返しで初期値を代入してもよい。

        static void Main(string[] args)
        {
            int[] list = new int[10];

            // 繰り返しで初期値を代入する
            for(int i= 0; i < list.Length; i++)
            {
                list[i] = i;
            }


            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
