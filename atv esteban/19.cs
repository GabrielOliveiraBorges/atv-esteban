using System;

class Program
{
    static int BuscarPalavra(string[] dicionario, string palavra)
    {
        int inicio = 0;
        int fim = dicionario.Length - 1;

        while (inicio <= fim)
        {
            int meio = (inicio + fim) / 2;

            int comparacao = string.Compare(dicionario[meio], palavra, StringComparison.OrdinalIgnoreCase);

            if (comparacao == 0)
            {
                return meio; 
            }
            else if (comparacao < 0)
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
        string[] dicionario = { "abacate", "banana", "carro", "dado", "elefante", "foca", "gato" };

        Console.Write("Digite a palavra que deseja buscar: ");
        string palavra = Console.ReadLine();

        int indice = BuscarPalavra(dicionario, palavra);

        if (indice != -1)
        {
            Console.WriteLine($"A palavra '{palavra}' foi encontrada na posição {indice}.");
        }
        else
        {
            Console.WriteLine($"A palavra '{palavra}' não foi encontrada no dicionário.");
        }
    }
}
