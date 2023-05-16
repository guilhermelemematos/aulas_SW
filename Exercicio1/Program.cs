namespace Exercicio1;
class Program
{
    static void Main(string[] args)
    {
        Animal a = new Animal();
        Homem h = new Homem();
        Gato g = new Gato();
        Cao c = new Cao();

        Console.WriteLine("O gato" + g.Fala());
        Console.WriteLine("O Cão" + c.Fala());
        Console.WriteLine("Homem" + h.Fala());
    }
}
