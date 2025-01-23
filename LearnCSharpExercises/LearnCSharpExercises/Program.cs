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
            string input; // 入力された文字列格納用
            int num; // 入力された文字列を整数でパースした結果を格納する用
            bool check = false; // 整数かどうかの判定フラグ 整数ならtrue、それ以外ならfalse
            
            do
            {
                Console.Write("input number: ");
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

            Console.WriteLine($"your number is {num}");
        }
    }
}
