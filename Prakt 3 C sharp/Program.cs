namespace Prakt_2_C_sharp;
using System;
class Program
{
    static void Main()
    {
        int[] array = { 1, 0, 2, 3, 0, -4, -5, 6 };

        // Обчислення добутку елементiв з парними номерами
        int evenProduct = 1;
        for (int i = 0; i < array.Length; i += 2)
        {
            evenProduct *= array[i];
        }
        Console.WriteLine($"Добуток елементiв з парними номерами: {evenProduct}");

        // Обчислення суми елементiв мiж першим i останнiм нульовим елементами
        int firstZeroIndex = Array.IndexOf(array, 0);
        int lastZeroIndex = Array.LastIndexOf(array, 0);
        int sumBetweenZeros = 0;
        if (firstZeroIndex != -1 && lastZeroIndex != -1)
        {
            for (int i = firstZeroIndex + 1; i < lastZeroIndex; i++)
            {
                sumBetweenZeros += array[i];
            }
        }
        Console.WriteLine($"Сума елементiв мiж першим i останнiм нульовими елементами: {sumBetweenZeros}");

        // Сортування масиву
        Array.Sort(array, (x, y) =>
        {
            if (x == 0)
            {
                return -1;
            }
            else if (y == 0)
            {
                return 1;
            }
            else if (x > 0 && y < 0)
            {
                return -1;
            }
            else if (x < 0 && y > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        });
        Console.WriteLine("Масив пiсля сортування:");
        Console.WriteLine(string.Join(", ", array));
    }
}

