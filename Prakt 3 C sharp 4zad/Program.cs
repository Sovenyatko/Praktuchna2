namespace Prakt_2_C_sharp_4zad;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Введення розмiру матрицi

        Console.Write("Введiть розмiр матрицi: ");
        int n = int.Parse(Console.ReadLine());
        if (n > -200 && n < 200)
        {  //Матриця не може мати розмiр вiд'ємного числа тому перша умова нiколи не може бути бо буде помилка

            int[,] matrix = new int[n, n];

            int count = 1;
            // Заповнення матрицi послiдовними числами вiд 1 до n^2
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = count;
                        count++;
                    }
                }
                else
                {
                    for (int j = n - 1; j >= 0; j--)
                    {
                        matrix[i, j] = count;
                        count++;
                    }
                }
            }

            Console.WriteLine("Матриця:");

            // Виведення заповненої матрицi
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }

            // Обмiн максимального та мiнiмального значення у кожному рядку
            for (int i = 0; i < n; i++)
            {
                int minIndex = 0;
                int maxIndex = 0;
                int min = matrix[i, 0];
                int max = matrix[i, 0];

                // Знаходження мiнiмального та максимального значення в рядку
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        minIndex = j;
                    }
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        maxIndex = j;
                    }
                }

                // Обмiн мiсцями мiнiмального та максимального значення
                matrix[i, minIndex] = max;
                matrix[i, maxIndex] = min;
            }

            Console.WriteLine("Матриця зi змiненими мiсцями мiнiмальних та максимальних значень:");

            // Виведення матрицi зi змiненими мiсцями мiнiмальних та максимальних значень
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        else
        {
            System.Console.WriteLine("Введiть iнше число");
        }
    }
}