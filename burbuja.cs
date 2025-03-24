using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10] { 8, 3, 7, 1, 9, 4, 2, 10, 6, 5 };

        for (int i = 0; i < numeros.Length - 1; i++)
        {
            for (int j = 0; j < numeros.Length - 1 - i; j++)
            {
                if (numeros[j] > numeros[j + 1])
                {
                    int temp = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nNúmeros ordenados de menor a mayor:");
        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }
    }
}
