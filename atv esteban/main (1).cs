using System;

class Program
{
    
    static int BuscarIndiceNome(string[] nomes, string nomeBuscado)
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            if (nomes[i] == nomeBuscado)
            {
                return i; 
            }
        }

        return -1; 
    }

    static void Main(string[] args)
    {
        string[] nomes = { "Ana", "Bruno", "Carlos", "Diana", "Eduardo" };
        string nomeProcurado = "Carlos";

        int indice = BuscarIndiceNome(nomes, nomeProcurado);

        if (indice != -1)
        {
            Console.WriteLine($"O nome '{nomeProcurado}' está no índice {indice}.");
        }
        else
        {
            Console.WriteLine($"O nome '{nomeProcurado}' não foi encontrado no array.");
        }
    }
}
