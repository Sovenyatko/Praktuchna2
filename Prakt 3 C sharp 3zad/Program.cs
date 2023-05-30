namespace Prakt_2_C_sharp_3zad;

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[300];

        // Заповнення масиву випадковими числами в діапазоні від -200 до 200
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-200, 201);
        }

        // Знаходження максимального та мінімального від'ємних значень
        int maxNegativeIndex = -1;
        int minNegativeIndex = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                if (maxNegativeIndex == -1 || array[i] > array[maxNegativeIndex])
                {
                    maxNegativeIndex = i;
                }
                if (minNegativeIndex == -1 || array[i] < array[minNegativeIndex])
                {
                    minNegativeIndex = i;
                }
            }
        }

        // Перестановка місцями елементів з максимальним та мінімальним від'ємним значенням
        if (maxNegativeIndex != -1 && minNegativeIndex != -1)
        {
            int temp = array[maxNegativeIndex];
            array[maxNegativeIndex] = array[minNegativeIndex];
            array[minNegativeIndex] = temp;
        }

        // Виведення масиву на екран
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
    }
}
