using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharpExercises
{
    internal class Program
    {
        //No. 05 四則演算
        //整数値を2つ入力させ、それらの値の和、差、積、商と余りを求めるプログラムを作成せよ。なお、差と商は1つ目の値から2つ目の値を引いた、あるいは割った結果とする。余りは無い場合も0と表示するのでよい。

        //【実行例、下線部は入力例】
        //$ ./knock05
        //input 1st number: 123
        //input 2nd number: 7
        //和: 130
        //差: 116
        //積: 861
        //商: 17, 余り: 4
        //$ ./knock05
        //input 1st number: 123
        //input 2nd number: 3
        //和: 126
        //差: 120
        //積: 369
        //商: 41, 余り: 0
        //$
        static void Main(string[] args)
        {
            int num1st = InputNumber("input 1st number: ");
            int num2nd = InputNumber("input 2nd number: ");

            Console.WriteLine($"和: {num1st + num2nd}");
            Console.WriteLine($"差: {num1st - num2nd}");
            Console.WriteLine($"積: {num1st * num2nd}");
            Console.WriteLine($"商: {num1st / num2nd}, 余り: {num1st % num2nd}");
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
