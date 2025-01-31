using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharpExercises
{
    internal class Program
    {

        //No. 15 2ずつカウントアップ
        //整数値を入力させ、0から入力値を超えない値まで2ずつ増やして表示するプログラムを作成せよ。

        //【実行例、下線部は入力例】
        //$ ./knock15
        //input number: 7
        //0
        //2
        //4
        //6
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

            for (int i = 0; i <= num; i+=2)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
