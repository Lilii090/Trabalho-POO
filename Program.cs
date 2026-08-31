using System;
using System.Reflection;


    class Program
    {
    static void Main(string[] args)
    {
        Console.WriteLine("--- TESTANDO AS CLASSES DO SISTEMA ---\n");
        Aluno aluno1 = new Aluno("Carlos Silva", 20);
        Aluno aluno2 = new Aluno("Ana Braga", 17);

        aluno1.Idade = 21;

        Console.WriteLine(aluno1.ToString());
        Console.WriteLine(aluno2.ToString());
        Console.WriteLine();

        Retangulo ret1 = new Retangulo(5.0, 3.0);
        Retangulo ret2 = new Retangulo(10.0, 4.0);

        ret1.Largura = 6.0;

        Console.WriteLine(ret1.ToString());
        Console.WriteLine(ret2.ToString());
        Console.WriteLine();

        Funcionario func1 = new Funcionario("Desenvolvedor", 4500.00);
        Funcionario func2 = new Funcionario("Gerente", 8000.00);

        func1.Salario = 4800.00;

        Console.WriteLine(func1.ToString());
        Console.WriteLine(func2.ToString());

        Console.ReadKey();
    }
    }



    