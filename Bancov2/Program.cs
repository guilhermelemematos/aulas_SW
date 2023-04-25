namespace BancoV2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Banco etec MCM");
        Conta c = new Conta();
        //c.Saldo = 1500;
        c.Depositar(1500);
        c.AjustaLimite(500);
        c.Sacar(5000);

        //Console.WriteLine("Seu saldo é de : " + c.Saldo + " e seu limite é de: " + c.Limite);
        Console.WriteLine("Seu saldo é de: " + c.MostrarSaldo());
        
        c.imprime(c.Emprestimo(1000, 12));
    }
}
