using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharpExercises
{
    internal class Program
    {
        //No. 19 配列に入力値を格納
        //要素数5の整数型の配列を宣言し、すべての配列に対して順に入力された整数値を代入し、すべての要素の値を表示するプログラムを作成せよ。

        //【実行例、下線部は入力例】
        //$ ./knock19
        //input number: 4
        //input number: 6
        //input number: 7
        //input number: 3
        //input number: 1
        //4
        //6
        //7
        //3
        //1
        //$

        static void Main(string[] args)
        {
            int[] list = new int[5];
            int num = 0;
            int count = 0;

            while (count < list.Length)
            {
                Console.Write("input number: ");
                var val = Console.ReadLine();

                if (int.TryParse(val, out num) == false)
                {
                    Console.WriteLine("整数を入力してください。");
                    continue;
                }
                else
                {
                    list[count] = num;
                    count++;
                }
            }

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
