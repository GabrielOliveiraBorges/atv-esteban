using System;

class Program
{
    static int PrimeiraOcorrencia(int[] array, int x)
    {
        int inicio = 0;
        int fim = array.Length - 1;
        int resultado = -1;

        while (inicio <= fim)
        {
            int meio = (inicio + fim) / 2;

            if (array[meio] == x)
            {
                resultado = meio;
                fim = meio - 1; 
            }
            else if (array[meio] < x)
            {
                inicio = meio + 1;
            }
            else
            {
                fim = meio - 1;
            }
        }

        return resultado;
    }

    static void Main(string[] args)
    {
        int[] numeros = { 1, 2, 4, 4, 4, 5, 6, 7 };

        Console.Write("Digite o número que deseja buscar: ");
        int x = int.Parse(Console.ReadLine());

        int posicao = PrimeiraOcorrencia(numeros, x);

        if (posicao != -1)
        {
            Console.WriteLine($"A primeira ocorrência de {x} está na posição {posicao}.");
        }
        else
        {
            Console.WriteLine($"O número {x} não foi encontrado no array.");
        }
    }
}
