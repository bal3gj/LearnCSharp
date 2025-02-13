using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharpExercises
{
    internal class Program
    {

        //No. 20 割って掛ける
        //整数値を2つ入力させ、1つめの値を2つめの値で割った結果を表示し、続けてその結果に2つめの値を掛けた結果を表示するプログラムを作成せよ。計算はすべて整数型で行うこと（割り切れない場合は自動的に小数点以下が切り捨てられる）。

        //【実行例、下線部は入力例】
        //$ ./knock20
        //input 1st value: 10
        //input 2nd value: 3
        //result: 3
        //result: 9
        //$
        //割りきれない場合、2つめの値を掛けても最初の1つめの値に戻らないことに注意。

        static void Main(string[] args)
        {

            int num1 = InputNumber("input 1st value: ");
            int num2 = 0;

            while (num2 == 0) // ゼロ割エラー対策 num2が0でないことをここで保証する
            {
                num2 = InputNumber("input 2nd value: ");
            }

            int result1 = num1 / num2;
            int result2 = result1 * num2;

            Console.WriteLine($"result: {result1}");
            Console.WriteLine($"result: {result2}");
        }

        static int InputNumber(string message)
        {
            int num = 0;

            while (true)
            {
                Console.Write(message);
                var val = Console.ReadLine();

                if (int.TryParse(val, out num) == false)
                {
                    Console.WriteLine("整数を入力してください。");
                    continue;
                }
                else
                {
                    break;
                }
            }

            return num;
        }
    }
}
