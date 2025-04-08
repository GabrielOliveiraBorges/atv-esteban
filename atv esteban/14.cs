using System;

class Program
{
    static void Main(string[] args)
    {
        int[] listaDeNumeros = { 1, 3, 5, 5, 5, 7, 9, 11, 11, 13 };

        Console.Write("Digite o número que você quer procurar: ");
        int numero = int.Parse(Console.ReadLine());

        bool encontrado = false;

        Console.WriteLine($"Procurando o número {numero}...");

        for (int i = 0; i < listaDeNumeros.Length; i++)
        {
            if (listaDeNumeros[i] == numero)
            {
                Console.WriteLine($"Encontrado na posição {i}");
                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Número não encontrado.");
        }
    }
}
