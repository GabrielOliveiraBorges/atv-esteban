using System;

class Program
{
    static int BuscaComSentinela(int[] arrayOriginal, int elemento)
    {
        int[] array = new int[arrayOriginal.Length + 1];
        Array.Copy(arrayOriginal, array, arrayOriginal.Length);

        array[arrayOriginal.Length] = elemento;

        int i = 0;

        while (array[i] != elemento)
        {
            i++;
        }

        if (i < arrayOriginal.Length)
        {
            return i; 
        }
        else
        {
            return -1
        }
    }

    static void Main(string[] args)
    {
        int[] numeros = { 4, 7, 10, 23, 8, 15 };
        int elementoBuscado = 23;

        int indice = BuscaComSentinela(numeros, elementoBuscado);

        if (indice != -1)
        {
            Console.WriteLine($"Elemento {elementoBuscado} encontrado no índice {indice}.");
        }
        else
        {
            Console.WriteLine("Elemento não encontrado.");
        }
    }
}
