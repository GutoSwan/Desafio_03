using System;

namespace desafio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<aluno>alunos = new List<aluno>();

            Console.WriteLine("digite a quantidade de alunos");
            int quantidadeAlunos = Convert.ToInt32(Console.ReadLine());

            for (var count = 0; count < quantidadeAlunos; count++)
            {
                aluno aluninho = new aluno();
                Console.WriteLine("digite o nome do aluno");
                aluninho.nome = Console.ReadLine();
                Console.WriteLine("digite a nota do aluno");
                aluninho.nota = Convert.ToInt32(Console.ReadLine());
                alunos.Add(aluninho);
            }
            var nomeAlunoMaiorNota = alunos.Select(x => x.nota).Max();
            Console.WriteLine($"aluno com a maior nota é: {alunos.Where(x => x.nota == nomeAlunoMaiorNota).Select(x => x.nome).FirstOrDefault()} ");

        }
    }
}