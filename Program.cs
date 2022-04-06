
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
            int[,] twoMassiv = new int[5,6];

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

            Console.ReadLine();
        }
    }
}
