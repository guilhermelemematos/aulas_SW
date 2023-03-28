namespace projeto_pessoa;
class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa("Guilherme", 16);
        //p1.AlteraNome("Guilherme");
        //p1.AlteraSobreNome("Leme");
        //p1.AlteraIdade(16);
        p1.MostraDados();
    }
}
