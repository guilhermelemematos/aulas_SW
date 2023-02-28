namespace classes;

class ClasseBanco{
    public int agencia;
    public string tipo = "";
    public int valor;
    public int conta;

    public void depositar(){
        valor++;
    }

     public void sacar(){
        valor--;
    }

     public void transferir(){
        valor++;
    }

     public void consultar(){
        conta--;
    }

    public void exibir(){
        Console.WriteLine("Dados da conta:");
        Console.WriteLine("Modelo:" + tipo);
        Console.WriteLine("numero da conta" + conta);
        Console.WriteLine("dinheiro na conta atual:" + valor);
    }
}
