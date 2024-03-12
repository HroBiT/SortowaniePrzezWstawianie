using System;

public class InsertionSort
{
    public static void Sort(int[] array)
    {
        int n = array.Length;

        for (int i = 1; i < n; ++i)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j = j - 1;
            }

            array[j + 1] = key;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int[] numbers = new int[100];

        // Generowanie tablicy stu liczb losowych
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 100);
        }

        // Wyświetlanie tablicy przed sortowaniem
        Console.WriteLine("Tablica przed sortowaniem:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // Sortowanie tablicy za pomocą InsertionSort
        InsertionSort.Sort(numbers);

        // Wyświetlanie tablicy po sortowaniu
        Console.WriteLine("Tablica po sortowaniu:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // Generowanie kopii tablicy do porównania
        int[] numbersCopy = (int[])numbers.Clone();

        // Sortowanie tablicy za pomocą wbudowanego sortowania
        Array.Sort(numbersCopy);

        // Porównanie tablic
        bool areEqual = numbers.SequenceEqual(numbersCopy);
        Console.WriteLine($"Czy tablice są równe? {areEqual}");
    }
}
