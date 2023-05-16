namespace Exercicio2;
class PessoaFisica:Contrato
{
    public long Cpf {get;set;}

   public int Idade {get;set;}

    public override string MostraDados(){
         return this.Nome + " - " + this.Email + " - " + this.Telefone + " - " + this.Idade + " - " + this.Cpf;
    }
}
