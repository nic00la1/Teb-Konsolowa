using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[50];
        FillArrayWithRandomValues(array);

        Console.WriteLine("Podaj wartość do wyszukania:");
        int valueToFind = int.Parse(Console.ReadLine());

        int index = SearchWithSentinel(array, valueToFind);

        Console.WriteLine("Zawartość tablicy: " + string.Join(", ", array));
        if (index != -1)
        {
            Console.WriteLine($"Wartość {valueToFind} znaleziona na indeksie {index}.");
        }
        else
        {
            Console.WriteLine($"Wartość {valueToFind} nie została znaleziona w tablicy.");
        }
    }

    /// <summary>
    /// Wypełnia tablicę liczbami pseudolosowymi z zakresu od 1 do 100.
    /// </summary>
    /// <param name="array">Tablica do wypełnienia.</param>
    static void FillArrayWithRandomValues(int[] array)
    {
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101);
        }
    }

    /// <summary>
    /// Przeszukuje tablicę z wartownikiem w celu znalezienia pierwszego wystąpienia wartości.
    /// </summary>
    /// <param name="array">Tablica do przeszukania.</param>
    /// <param name="valueToFind">Wartość do znalezienia.</param>
    /// <returns>Indeks pierwszego wystąpienia wartości lub -1, jeśli wartość nie została znaleziona.</returns>
    static int SearchWithSentinel(int[] array, int valueToFind)
    {
        int n = array.Length;
        int last = array[n - 1];
        array[n - 1] = valueToFind;
        int i = 0;
        while (array[i] != valueToFind)
        {
            i++;
        }
        array[n - 1] = last;
        if (i < n - 1 || array[n - 1] == valueToFind)
        {
            return i;
        }
        return -1;
    }
}
