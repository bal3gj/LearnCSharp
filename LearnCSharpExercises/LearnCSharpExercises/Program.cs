using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharpExercises
{
    internal class Program
    {

        //整数値を入力させ、0から入力値まで数を1ずつ増やして表示するプログラムを作成せよ。

        //【実行例、下線部は入力例】
        //$ ./knock13
        //input number: 5
        //0
        //1
        //2
        //3
        //4
        //5
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

            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
