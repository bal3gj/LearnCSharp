using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharpExercises
{
    internal class Program
    {
        //No. 04 入力と計算
        //整数値を入力させ、その入力値を3倍した計算結果を表示するプログラムを作成せよ。

        //【実行例、下線部は入力例】
        //$ ./knock04
        //input number: 123
        //answer = 369
        //$

        static void Main(string[] args)
        {
            int num = InputNumber("input number: ");

            Console.WriteLine($"answer = {num * 3}");
        }

        /// <summary>
        /// 整数を入力させる
        /// </summary>
        /// <param name="message">メッセージ</param>
        /// <returns>入力された整数</returns>
        static int InputNumber(string message)
        {
            int num = -1; // 入力された整数値
            string input; // 入力された文字列格納用
            bool check = false; // 整数かどうかの判定フラグ 整数ならtrue、それ以外ならfalse

            do
            {
                Console.Write(message);
                input = Console.ReadLine();

                if (int.TryParse(input, out num) == false)
                {
                    Console.WriteLine($"整数を入力してください");
                }
                else
                {
                    check = true;
                }

            } while (check == false); // 整数が入力されるまで上記繰り返す

            return num;

        }
    }
}
