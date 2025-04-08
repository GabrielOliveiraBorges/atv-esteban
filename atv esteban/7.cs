using System;

class Program
{
    static int EncontrarMultiplo(int[] array, int x)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % x == 0)
            {
                return array[i]; 
            }
        }

        return -1; 

    static void Main(string[] args)
    {
        int[] numeros = { 7, 13, 18, 21, 29 };
        int x = 3;

        int multiplo = EncontrarMultiplo(numeros, x);

        if (multiplo != -1)
        {
            Console.WriteLine($"O primeiro número múltiplo de {x} é: {multiplo}");
        }
        else
        {
            Console.WriteLine($"Nenhum número múltiplo de {x} foi encontrado no array.");
        }
    }
}
