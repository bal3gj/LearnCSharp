using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharpExercises
{
    internal class Program
    {
        //No. 03 入力
        //整数値を入力させ、その入力値を表示するプログラムを作成せよ。

        //【実行例、下線部は入力例】
        //$ ./knock03
        //input number: 123
        //your number is 123
        //$

        static void Main(string[] args)
        {
            Console.Write("input number: ");
            string input = Console.ReadLine();
            Console.WriteLine($"your number is {input}");
        }
    }
}
