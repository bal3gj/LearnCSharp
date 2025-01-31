using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharpExercises
{
    internal class Program
    {

        //No. 07 0 or not 0
        //整数値を入力させ、値が0ならzero、0でなければnot zeroと表示するプログラムを作成せよ。

        //【実行例、下線部は入力例】
        //$ ./knock07
        //input number: 0
        //zero
        //$ ./knock07
        //input number: 1
        //not zero
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

                if(int.TryParse(val, out num) == false)
                {
                    Console.WriteLine("整数を入力してください。");
                    continue;
                }
                
                if (num == 0)
                {
                    Console.WriteLine("zero");
                }
                else
                {
                    Console.WriteLine("not zero");
                }
            }
        }
    }
}
