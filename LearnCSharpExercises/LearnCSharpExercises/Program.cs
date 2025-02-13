using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharpExercises
{
    internal class Program
    {

        //No. 16 0でおしまい
        //整数値を入力させ、入力値が0でなければ再度入力させ、0であれば終了するプログラムを作成せよ。

        //【実行例、下線部は入力例】
        //$ ./knock16
        //input number: 5
        //input number: 3
        //input number: -4
        //input number: 0
        //$
        //do-while文を使う、あるいは無限ループをbreak文で抜け出す。

        static void Main(string[] args)
        {
            int num = -1;

            while (num != 0)
            {
                Console.Write("input number: ");
                var val = Console.ReadLine();

                if (int.TryParse(val, out num) == true && num == 0)
                {
                    break;
                }
            }
        }
    }
}
