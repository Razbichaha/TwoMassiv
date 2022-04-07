
using System;

namespace Двумерный_массив
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minRandom = 0;
            int maxRandom = 10;
            int line = 5;
            int column = 6;
            int[,] twoMassiv = new int[line,column];

            for (int i = 0; i < twoMassiv.GetLength(0);i++)
            {

                for(int ii=0;ii<twoMassiv.GetLength(1);ii++)
                {
                    twoMassiv[i, ii] = random.Next(minRandom, maxRandom);
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

            int sum = 0;
            int stringPointer = 1;

            for(int i=0;i< twoMassiv.GetLength(stringPointer);i++)
            {
                sum += twoMassiv[stringPointer,i];
            }

            Console.Write("Сумма второй строки = " + sum + "\n");
            int columnPointer = 0;
            int multiplication = 1;

            for (int i = 0; i < twoMassiv.GetLength(columnPointer); i++)
            {
                multiplication *= twoMassiv[i, columnPointer];
            }

            Console.Write("Произведение первого столбца = " + multiplication + "\n");
            Console.ReadLine();
        }
    }
}
