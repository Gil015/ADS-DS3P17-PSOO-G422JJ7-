using System;
using System.IO.Compression;
class Program
{
    static void Main()
    {
       Aluno aluno = new Aluno();
       aluno.Mostrarnome();
       aluno.MostrarIdade();
       aluno.Mostrarra();
       aluno.Mostrarturma();
       

}
}
public class Pessoa 
{
    public string nome = "Victor Gil";
    public int idade = 19;

    public void Mostrarnome()
    {
        Console.WriteLine("O nome do Aluno é:" + nome);
    }
    public void MostrarIdade()
    {
        Console.WriteLine("A idade do Aluno é:" + idade);
    }


}
public class Aluno :Pessoa
{
    public string ra = "G422JJ7";
    public string turma = "DS3P17";

    public void Mostrarra()
    {
        Console.WriteLine("O RA do aluno é: " + ra);
    }
    public void Mostrarturma()
    {
        Console.WriteLine("A Turma do aluno é: " + turma);
    }
}