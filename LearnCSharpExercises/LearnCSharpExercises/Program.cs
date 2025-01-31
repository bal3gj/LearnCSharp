using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharpExercises
{
    internal class Program
    {
        //No. 06 0?
        //整数値を入力させ、値が0ならzeroと表示するプログラムを作成せよ。

        //【実行例、下線部は入力例】
        //$ ./knock06
        //input number: 0
        //zero
        //$ ./knock06
        //input number: 1
        //$

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("input number: ");
                var val = Console.ReadLine();

                if(val == "0")
                {
                    Console.WriteLine("zero");
                }
                else if(val == "quit") // quit と入力されたら終了
                {
                    break;
                }
            }
        }
    }
}
