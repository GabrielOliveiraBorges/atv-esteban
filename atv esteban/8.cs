using System;

class Aluno
{
    public string Nome { get; set; }
    public int Matricula { get; set; }

    public Aluno(string nome, int matricula)
    {
        Nome = nome;
        Matricula = matricula;
    }
}

class Program
{
    static Aluno BuscarAlunoPorMatricula(Aluno[] alunos, int matriculaProcurada)
    {
        for (int i = 0; i < alunos.Length; i++)
        {
            if (alunos[i].Matricula == matriculaProcurada)
            {
                return alunos[i]; 
            }
        }

        return null; 
    }

    static void Main(string[] args)
    {
        Aluno[] alunos = {
            new Aluno("Ana", 101),
            new Aluno("Bruno", 102),
            new Aluno("Carlos", 103)
        };

        int matriculaBuscada = 102;

        Aluno alunoEncontrado = BuscarAlunoPorMatricula(alunos, matriculaBuscada);

        if (alunoEncontrado != null)
        {
            Console.WriteLine($"Aluno encontrado: {alunoEncontrado.Nome}, Matrícula: {alunoEncontrado.Matricula}");
        }
        else
        {
            Console.WriteLine("Aluno não encontrado.");
        }
    }
}

