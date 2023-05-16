namespace Exercicio3;
class PessoaJuridica:Contrato
{
    public long Inscricao {get;set;}

    public long Cnpj {get;set;}

    public string? NomeEmpresa {get;set;}


    public override string MostraDados(){
        return this.Nome + " - " + this.Email + " - " + this.Telefone + " - " + this.Cnpj + " - " + this.Inscricao + " - " + this.NomeEmpresa;
    }

    public override double CalcualarPrestacao(){
        return ((base.CalcualarPrestacao()/Prazo)+3);
    }
}
