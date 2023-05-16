namespace Exercicio3;
class Program
{
    static void Main(string[] args)
    {
        Contrato c = new Contrato();
        PessoaFisica cf = new PessoaFisica();
        PessoaJuridica cj = new PessoaJuridica();

        cf.Nome = "Guilherme";
        cf.Email = "Gui@gmail.com";
        cf.Telefone = "819384718";
        cf.Idade = 24;
        cf.Cpf = 24699642123;
        cf.Prazo = 10;
        cj.Nome = "ETEC";
        cj.Email = "etec@gmail.com";
        cj.Telefone = "0102030405";
        cj.Cnpj = 1234554321;
        cj.Inscricao = 098765567890;
        cj.NomeEmpresa = "Etec MCM";

        Console.WriteLine(cf.MostraDados());
        Console.WriteLine(cf.CalcualarPrestacao());
        Console.WriteLine(cj.MostraDados());
        Console.WriteLine(cj.CalcualarPrestacao());
    }
}
