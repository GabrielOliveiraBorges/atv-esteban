using System;

class Program
{
    static int ContarOcorrencias(int[] array, int elemento)
    {
        int contador = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == elemento)
            {
                contador++;
            }
        }

        return contador;
    }

    static void Main(string[] args)
    {
        int[] numeros = { 10, 20, 30, 20, 40, 50, 20 };
        int elementoBuscado = 20;

        int quantidade = ContarOcorrencias(numeros, elementoBuscado);

        if (quantidade > 0)
        {
            Console.WriteLine($"O elemento {elementoBuscado} aparece {quantidade} vez(es) no array.");
        }
        else
        {
            Console.WriteLine("Elemento não encontrado no array.");
        }
    }
}
