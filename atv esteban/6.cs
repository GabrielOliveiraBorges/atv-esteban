using System;

class Program
{
    static void EncontrarMaiorEMenor(int[] array, out int maior, out int menor)
    {
        maior = array[0];
        menor = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maior)
            {
                maior = array[i];
            }
            else if (array[i] < menor)
            {
                menor = array[i];
            }
        }
    }

    static void Main(string[] args)
    {
        int[] numeros = { 25, 7, 89, 14, 3, 56 };

        EncontrarMaiorEMenor(numeros, out int maior, out int menor);

        Console.WriteLine($"Maior número: {maior}");
        Console.WriteLine($"Menor número: {menor}");
    }
}
