namespace Ex30_05;
class Nacional:Produto
{
    public double Taxa {get; set;}

    public override double calculaValor()
    {
        double tx = this.Valor*(this.Taxa/100);
        return base.calculaValor()+tx;
    }
}
