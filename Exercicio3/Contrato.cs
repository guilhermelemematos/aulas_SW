namespace Exercicio3;
class Contrato
{
    public string? Nome {get;set;}

   public string? Email {get;set;}

   public string? Telefone {get;set;}

   public int Prazo {get; set;}

   public virtual string MostraDados(){
      return this.Nome + " - " + this.Email + " - " + this.Telefone;
    }

    public virtual double CalcualarPrestacao(){
      return 1200;
    }
}
