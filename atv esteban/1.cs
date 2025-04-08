using System;

class Program
{
    static int BuscaSequencial(int[] array, int elemento)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == elemento)
            {
                return i; 
            }
        }
        return -1;
    }

    static void Main(string[] args)
    {
        int[] numeros = { 10, 20, 30, 40, 50 };
        int elementoBuscado = 30;

        int indice = BuscaSequencial(numeros, elementoBuscado);

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
