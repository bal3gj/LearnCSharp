using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharpExercises
{
    internal class Program
    {

        //No. 02 余り
        //12345を7で割った余りを表示するプログラムを作成せよ。

        //【実行例】
        //$ ./knock02
        //12345 ÷ 7 の余りは 4
        //$
        //変数は使用してもしなくてもよい。

        static void Main(string[] args)
        {
            int a = 12345;
            int b = 7;
            Console.WriteLine($"{a} ÷ {b} の余りは {a % b}");
        }
    }
}
