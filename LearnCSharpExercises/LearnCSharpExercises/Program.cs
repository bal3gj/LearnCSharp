using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharpExercises
{
    internal class Program
    {

        //No. 10 絶対値
        //整数値を入力させ、その値を絶対値にして表示するプログラムを作成せよ。（できれば変数の値を絶対値に変えるようにせよ）

        //【実行例、下線部は入力例】
        //$ ./knock10
        //input number: 1
        //absolute value is 1
        //$ ./knock10
        //input number: -2
        //absolute value is 2
        //$

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("input number: ");
                var val = Console.ReadLine();

                if (val == "quit") // quit と入力されたら終了
                {
                    break;
                }

                int num;

                if (int.TryParse(val, out num) == false)
                {
                    Console.WriteLine("整数を入力してください。");
                    continue;
                }

                num = Math.Abs(num); // 絶対値を取得

                //↑ num = Math.Abs(num); と同等の処理を行う別解
                //if (num < 0)
                //{
                //    num *= -1;
                //}

                Console.WriteLine($"absolute value is {num}");
            }
        }
    }
}
