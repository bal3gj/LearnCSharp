using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharpExercises
{
    internal class Program
    {
        //No. 01 足し算
        //12345+23456を計算して結果を表示するプログラムを作成せよ。

        //【実行例】
        //$ ./knock01
        //12345 + 23456 = 35801
        //$

        static void Main(string[] args)
        {
            int a = 12345;
            int b = 23456;
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
    }
}
