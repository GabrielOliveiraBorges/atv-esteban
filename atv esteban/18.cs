using System;

class Program
{
    static int EncontrarPosicaoInsercao(int[] array, int x)
    {
        int inicio = 0;
        int fim = array.Length;

        while (inicio < fim)
        {
            int meio = (inicio + fim) / 2;

            if (array[meio] < x)
            {
                inicio = meio + 1;
            }
            else
            {
                fim = meio;
            }
        }

        return inicio; 
    }

    static void Main(string[] args)
    {
        int[] numeros = { 1, 3, 5, 7, 9 };

        Console.Write("Digite o número a ser inserido: ");
        int x = int.Parse(Console.ReadLine());

        int posicao = EncontrarPosicaoInsercao(numeros, x);

        Console.WriteLine($"O número {x} deve ser inserido na posição {posicao} para manter a ordem.");
    }
}
