namespace BancoV2;
class Conta
{
    public int Numero {get; set;}
    private double Saldo {get; set;}
    public double Limite {get; set;}
    public double ValorEmprestimo {get; set;}
    public double Mes {get; set;}
 

    public void Depositar(double valor){
        this.Saldo += valor;
    }

    public void Sacar(double valor){
        if(valor > this.Saldo + this.Limite){
            Console.WriteLine("Você não pode realizar esse saque! Saldo insuficiente");
        }else{
        this.Saldo -= valor;
        }
    }

    public double MostrarSaldo(){
        return this.Saldo + this.Limite;
    }

    public void AjustaLimite(double valor){
        this.Limite = valor;
    }

    public string Emprestimo(double emprestimo, int mes){
        this.ValorEmprestimo = emprestimo;
        this.Mes = mes;
        double parcelaSemJuros = this.ValorEmprestimo / this.Mes;
        double Juros = this.ValorEmprestimo * 0.06;
        double ParcelaJuros = parcelaSemJuros + Juros;
        double Total = ParcelaJuros * this.Mes;
        string resultado = "O valor do seu empréstimo total é de: " + Total;

        return resultado;
    }

    public void imprime(string texto){
        Console.WriteLine(texto);
    }
}
