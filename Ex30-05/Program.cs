namespace Ex30_05;
class Program
{
    static void Main(string[] args)
    {
        //classes filhas
        Estadual prodEstadual = new Estadual();
        Nacional prodNacional = new Nacional();
        Importado prodImportado = new Importado();

        //valores Estadual
        Console.WriteLine("Digite a descrição do produto Estadual:");
        prodEstadual.Descricao = Console.ReadLine();
        Console.WriteLine("Digite o valor do produto Estadual:");
        prodEstadual.Valor = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor do imposto do produto Estadual:");
        prodEstadual.Imposto = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Valor do produto calculado com Imposto: ");
        Console.WriteLine(prodEstadual.calculaValor());

        //valores Nacional
        Console.WriteLine("Digite a descrição do produto Nacional:");
        prodNacional.Descricao = Console.ReadLine();
        Console.WriteLine("Digite o valor do produto Nacional:");
        prodNacional.Valor = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor do imposto do produto Nacional:");
        prodNacional.Imposto = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor da Taxa do produto Nacional:");
        prodNacional.Taxa = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Valor do produto calculado com Imposto: ");
        Console.WriteLine(prodNacional.calculaValor());

        //valores Importado
        Console.WriteLine("Digite a descrição do produto Importado:");
        prodImportado.Descricao = Console.ReadLine();
        Console.WriteLine("Digite o valor do produto Importado:");
        prodImportado.Valor = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor do imposto do produto Importado:");
        prodImportado.Imposto = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor da Taxa do produto Importado:");
        prodImportado.Taxa = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor da Taxa do produto Importado:");
        prodImportado.TaxaImport = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Valor do produto calculado com Imposto: ");
        Console.WriteLine(prodImportado.calculaValor());
    }
}
