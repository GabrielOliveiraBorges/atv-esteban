using System;

class Program
{
    static int BuscarUltimaOcorrencia(int[] array, int elemento)
    {
        int indice = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == elemento)
            {
                indice = i;
            }
        }

        return indice;
    }

    static void Main(string[] args)
    {
        int[] numeros = { 5, 8, 2, 8, 3, 8, 1 };
        int elementoBuscado = 8;

        int indice = BuscarUltimaOcorrencia(numeros, elementoBuscado);

        if (indice != -1)
        {
            Console.WriteLine($"A última ocorrência do elemento {elementoBuscado} está no índice {indice}.");
        }
        else
        {
            Console.WriteLine("Elemento não encontrado.");
        }
    }
}
