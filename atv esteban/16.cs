using System;

class Program
{
    static int MaiorMenorQueX(int[] array, int x)
    {
        int resultado = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < x)
            {
                resultado = array[i]; 
            }
            else
            {
                break; 
            }
        }

        return resultado;
    }

    static void Main(string[] args)
    {
        int[] numeros = { 2, 4, 6, 8, 10, 12 };

        Console.Write("Digite o valor de X: ");
        int x = int.Parse(Console.ReadLine());

        int resultado = MaiorMenorQueX(numeros, x);

        if (resultado != -1)
        {
            Console.WriteLine($"O maior número menor que {x} é: {resultado}");
        }
        else
        {
            Console.WriteLine($"Não existe número menor que {x} no array.");
        }
    }
}
