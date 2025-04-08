using System;

class Program
{
    static int BuscaBinaria(int[] array, int elemento)
    {
        int inicio = 0;
        int fim = array.Length - 1;

        while (inicio <= fim)
        {
            int meio = (inicio + fim) / 2;

            if (array[meio] == elemento)
            {
                return meio; 
            }
            else if (array[meio] < elemento)
            {
                inicio = meio + 1; 
            }
            else
            {
                fim = meio - 1; 
            }
        }

        return -1; 
    }

    static void Main(string[] args)
    {
        int[] numeros = { 2, 4, 6, 8, 10, 12, 14, 16 };
        int elementoBuscado = 10;

        int indice = BuscaBinaria(numeros, elementoBuscado);

        if (indice != -1)
        {
            Console.WriteLine($"Elemento {elementoBuscado} encontrado no índice {indice}.");
        }
        else
        {
            Console.WriteLine($"Elemento {elementoBuscado} não encontrado no array.");
        }
    }
}
