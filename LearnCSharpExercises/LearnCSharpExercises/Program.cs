using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharpExercises
{
    internal class Program
    {

        //No. 11 ごあいさつ10回
        //Hello World!を10回繰り返して表示するプログラムを作成せよ。

        //【実行例、下線部は入力例】
        //$ ./knock11
        //Hello World!
        //Hello World!
        //Hello World!
        //Hello World!
        //Hello World!
        //Hello World!
        //Hello World!
        //Hello World!
        //Hello World!
        //Hello World!
        //$

        static void Main(string[] args)
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("Hello World!");
            }
        } // 出力結果を確認する場合はこの行にブレークポイントを設定してデバッグ実行すると良いですよ
    }
}
