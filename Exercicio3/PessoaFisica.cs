namespace Exercicio3;
class PessoaFisica:Contrato
{
    public long Cpf {get;set;}

   public int Idade {get;set;}

    public override string MostraDados(){
         return this.Nome + " - " + this.Email + " - " + this.Telefone + " - " + this.Idade + " - " + this.Cpf;
    }

    public override double CalcualarPrestacao(){
        if (Idade < 30){
            return ((base.CalcualarPrestacao()/Prazo)+1);
        }
        else if (Idade < 40){
            return ((base.CalcualarPrestacao()/Prazo)+2);
        }
        else if (Idade < 50){
            return ((base.CalcualarPrestacao()/Prazo)+3);
        }
        else{
            return ((base.CalcualarPrestacao()/Prazo)+4);
        }
    }
}
