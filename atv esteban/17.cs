using System;

class Program
{
    static int MenorMaiorQueX(int[] array, int x)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > x)
            {
                return array[i]; 
            }
        }

        return -1; 
    }

    static void Main(string[] args)
    {
        int[] numeros = { 2, 4, 6, 8, 10, 12 };

        Console.Write("Digite o valor de X: ");
        int x = int.Parse(Console.ReadLine());

        int resultado = MenorMaiorQueX(numeros, x);

        if (resultado != -1)
        {
            Console.WriteLine($"O menor número maior que {x} é: {resultado}");
        }
        else
        {
            Console.WriteLine($"Não existe número maior que {x} no array.");
        }
    }
}

