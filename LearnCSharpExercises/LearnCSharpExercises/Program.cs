using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharpExercises
{
    internal class Program
    {

        //No. 12 ごあいさつ指定回
        //整数値を入力させ、その値の回数だけHello World!を繰り返して表示するプログラムを作成せよ。

        //【実行例、下線部は入力例】
        //$ ./knock12
        //input number: 7
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
            int num = 0;

            while (num <= 0)
            {
                Console.Write("input number: ");
                var val = Console.ReadLine();

                if (int.TryParse(val, out num) == false || num <= 0)
                {
                    Console.WriteLine("1以上の整数を入力してください。");
                    continue;
                }
            }

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}
