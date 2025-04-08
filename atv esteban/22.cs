using System;

class Program
{
    static int MaisProximoDeX(int[] array, int x)
    {
        int inicio = 0;
        int fim = array.Length - 1;
        int maisProximo = array[0];

        while (inicio <= fim)
        {
            int meio = (inicio + fim) / 2;
            int atual = array[meio];

            if (Math.Abs(atual - x) < Math.Abs(maisProximo - x))
            {
                maisProximo = atual;
            }
            else if (Math.Abs(atual - x) == Math.Abs(maisProximo - x) && atual < maisProximo)
            {
                maisProximo = atual;
            }

            if (atual < x)
            {
                inicio = meio + 1;
            }
            else if (atual > x)
            {
                fim = meio - 1;
            }
            else
            {
                return atual;
            }
        }

        return maisProximo;
    }

    static void Main(string[] args)
    {
        int[] numeros = { 2, 5, 9, 13, 17, 21, 30 };

        Console.Write("Digite o valor de X: ");
        int x = int.Parse(Console.ReadLine());

        int proximo = MaisProximoDeX(numeros, x);

        Console.WriteLine($"O número mais próximo de {x} é: {proximo}");
    }
}
