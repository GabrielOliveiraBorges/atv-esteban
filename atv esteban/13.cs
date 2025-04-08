using System;

class Program
{
    static bool NumeroExiste(int[] array, int numero)
    {
        int inicio = 0;
        int fim = array.Length - 1;

        while (inicio <= fim)
        {
            int meio = (inicio + fim) / 2;

            if (array[meio] == numero)
            {
                return true; 
            }
            else if (array[meio] < numero)
            {
                inicio = meio + 1;
            }
            else
            {
                fim = meio - 1;
            }
        }

        return false; 
    }

    static void Main(string[] args)
    {
        int[] numeros = { 1, 3, 5, 7, 9, 11, 13, 15 }; 

        Console.Write("Digite o número a ser buscado: ");
        int numero = int.Parse(Console.ReadLine());

        bool existe = NumeroExiste(numeros, numero);

        if (existe)
        {
            Console.WriteLine($"O número {numero} existe na lista.");
        }
        else
        {
            Console.WriteLine($"O número {numero} NÃO existe na lista.");
        }
    }
}
