using System;
using System.Security.Cryptography.X509Certificates;


    public class Aluno
{
    private string nome;
    private int idade;

    public Aluno(string nome,int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public string Nome
    {
        get {return nome;}
        set
        {
            if (!string.IsNullOrEmpty(value))
                nome = value;
            else
                nome = "Sem Nome";
        }
    }

    public int Idade
    {
        get {return idade;}
        set
        {
            if (value > 0)
                idade = value;
            else
                idade = 18;
        }
    }

    public override string ToString()
    {
        return $"Aluno: {Nome} | Idade: {Idade} anos";
    }
}