﻿namespace ExercicioAlunos;
class Program
{
    static void Main(string[] args)
    {
        Alunos aluno1 = new Alunos();
        Console.WriteLine("Digite seu nome: ");
        aluno1.nome = Console.ReadLine();
        
        Console.WriteLine("Digite a nota1: ");
        aluno1.nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota2: ");
        aluno1.nota2 = double.Parse(Console.ReadLine());

        aluno1.mensagem();
    }
}
