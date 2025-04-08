using System;

class Program
{
    static int BuscarPrimeiroPar(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0) 
            {
                return array[i]; 
            }
        }

        return -1; 
    }

    static void Main(string[] args)
    {
        int[] numeros = { 3, 7, 9, 11, 14, 17 };

        int primeiroPar = BuscarPrimeiroPar(numeros);

        if (primeiroPar != -1)
        {
            Console.WriteLine($"O primeiro número par no array é: {primeiroPar}");
        }
        else
        {
            Console.WriteLine("Nenhum número par foi encontrado no array.");
        }
    }
}
