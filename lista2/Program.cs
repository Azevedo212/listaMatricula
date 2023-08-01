using System;

class Program
{
    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();
        aluno1.Nome = "Elias";
        aluno1.Cpf = "222";

        Aluno aluno2 = new Aluno(11, "maria", "04666440275", new DateOnly(1995,07,22));

        List<Aluno> alunos = new List<Aluno>();
        alunos.Add(aluno1);
        alunos.Add(aluno2);

        foreach(Aluno a in alunos)
        {
            Console.WriteLine($"O nome é: {a.Nome}\nO cpf de {a.Nome} é: {a.Cpf}\n ");
        }
    }
}