using System;

class Program
{
    static int BuscarPalavra(string texto, string palavra)
    {
        int tamanhoTexto = texto.Length;
        int tamanhoPalavra = palavra.Length;

        for (int i = 0; i <= tamanhoTexto - tamanhoPalavra; i++)
        {
            bool encontrou = true;

            for (int j = 0; j < tamanhoPalavra; j++)
            {
                if (texto[i + j] != palavra[j])
                {
                    encontrou = false;
                    break;
                }
            }

            if (encontrou)
            {
                return i; 
            }
        }

        return -1;
    }

    static void Main(string[] args)
    {
        Console.Write("Digite o texto: ");
        string texto = Console.ReadLine();

        Console.Write("Digite a palavra a ser buscada: ");
        string palavra = Console.ReadLine();

        int posicao = BuscarPalavra(texto, palavra);

        if (posicao != -1)
        {
            Console.WriteLine($"A palavra '{palavra}' foi encontrada na posição {posicao}.");
        }
        else
        {
            Console.WriteLine($"A palavra '{palavra}' não foi encontrada no texto.");
        }
    }
}
