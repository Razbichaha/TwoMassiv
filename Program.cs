
using System;

namespace Двумерный_массив
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int startRandom = 0;
            int stopRandom = 10;
            int Line = 4;
            int column = 3;
            int[,] twoMassiv = new int[Line,column];

            for (int i = 0; i < twoMassiv.GetLength(0);i++)
            {

                for(int ii=0;ii<twoMassiv.GetLength(1);ii++)
                {
                    twoMassiv[i, ii] = randomNumber.Next(startRandom, stopRandom);
                }
            }

            for (int i = 0; i < twoMassiv.GetLength(0); i++)
            {

                for (int ii = 0; ii < twoMassiv.GetLength(1); ii++)
                {
                    Console.Write(twoMassiv[i,ii]+" ");
                }

                Console.Write("\n");
            }

            int temp = 0;
            int stringPointer = 1;

            for(int i=0;i< twoMassiv.GetLength(stringPointer);i++)
            {
                temp += twoMassiv[stringPointer,i];
            }

            Console.Write("Сумма второй строки = " + temp + "\n");
            int columnPointer = 0;
            temp = 1;

            for (int i = 0; i < twoMassiv.GetLength(columnPointer); i++)//\\\\\\\\\\\\\\\\\\
            {
                temp *= twoMassiv[i, columnPointer];
            }

            Console.Write("Произведение первого столбца = " + temp + "\n");
            Console.ReadLine();
        }
    }
}
