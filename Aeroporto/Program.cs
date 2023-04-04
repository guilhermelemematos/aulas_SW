namespace Aeroporto;
class Program
{
    static void Main(string[] args)
    {
        Aeroporto a1 = new Aeroporto();
        a1.AlteraCodigo(1);
        a1.AlteraNome("Quatar Airlines");
        // a1.AlteraEntrada("Tupi");
        // a1.AlteraSaida("Jua");
        a1.MostraDados();

    }
}
