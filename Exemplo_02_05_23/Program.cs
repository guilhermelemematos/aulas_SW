namespace Exemplo;
class Program
{
    static void Main(string[] args)
    {
        FuncionarioN1 n1 = new FuncionarioN1();
        FuncionarioN2 n2 = new FuncionarioN2();
        FuncionarioN3 n3 = new FuncionarioN3();

        n1.Nome = "Gui";
        n1.Idade = 16;
        n2.Nome ="garcia";
        n2.Idade = 17;
        n3.Nome = "Julia";
        n3.Idade = 17;
        n3.Cargo = "Gerente";

        Console.WriteLine("Nome: " + n1.Nome + ", idade: " + n1.Idade + ", lucro: " + n1.Lucro());
        Console.WriteLine("Nome: " + n2.Nome + ", idade: " + n2.Idade + ", lucro: " + n2.Lucro());
        Console.WriteLine("Nome: " + n3.Nome + ", idade: " + n3.Idade + ", lucro: " + n3.Lucro() + ", Cargo: " + n3.Cargo);
    }
}
