namespace agregação;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Trabalhando com agregação!");

        Cartao cdc = new Cartao();
        Cliente cli = new Cliente();

        cli.Nome = "Guilherme Leme";

        cdc.Numero = "123456";
        cdc.DataValidade = "04/28";

        cdc.Cliente = cli;

        Console.WriteLine("O nome do cliente é: " + cli.Nome);
        Console.WriteLine("O numero do cartão é: " + cdc.Numero);
        Console.WriteLine("A data de vadilidade é: " + cdc.DataValidade);
        Console.WriteLine("O nome do cliente  AGREGADO é: " + cdc.Cliente.Nome);
    }
}
