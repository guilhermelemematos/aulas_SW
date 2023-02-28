namespace ex_aviao;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("EXERCÍCIO AVIÃO POO");
        Aviao aviao1 = new Aviao();
        
        aviao1.modelo = "Airbus A330";
        aviao1.marca = "aeroline";
        
        aviao1.exibir();
        aviao1.acelerar();
        aviao1.exibir();
        aviao1.acelerar();
        aviao1.exibir();
    }
}