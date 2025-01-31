using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharpExercises
{
    internal class Program
    {
        //No. 09 正? 負? 0?
        //整数値を入力させ、値が正であればpositive、負であればnegative、0であればzeroと表示するプログラムを作成せよ。

        //【実行例、下線部は入力例】
        //$ ./knock09
        //input number: 1
        //positive
        //$ ./knock09
        //input number: -1
        //negative
        //$ ./knock09
        //input number: 0
        //zero
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

                if (num > 0)
                {
                    Console.WriteLine("positive");
                }
                else if (num < 0)
                {
                    Console.WriteLine("negative");
                }
                else if (num == 0)
                {
                    Console.WriteLine("zero");
                }
                else
                {
                    // NOP
                }
            }
        }
    }
}
