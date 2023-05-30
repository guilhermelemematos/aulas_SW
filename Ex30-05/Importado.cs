namespace Ex30_05;
class Importado:Produto
{
    public double Taxa {get; set;}
    public double TaxaImport {get; set;}

    public override double calculaValor()
    {
        double tx = this.Valor*(this.Taxa/100);
        double tximp = this.Valor*(this.TaxaImport/100);
        return base.calculaValor() + tx + tximp;
    }
}