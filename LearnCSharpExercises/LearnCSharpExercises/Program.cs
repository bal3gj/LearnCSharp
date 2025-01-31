using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharpExercises
{
    internal class Program
    {

        //整数値を入力させ、入力値から0まで数を1ずつ減らして表示するプログラムを作成せよ。

        //【実行例、下線部は入力例】
        //$ ./knock14
        //input number: 5
        //5
        //4
        //3
        //2
        //1
        //0
        //$
        //入力値に0以下の値を入力した場合は考慮しなくてもよい。

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

            for (int i = num; i >= 0; i--)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
