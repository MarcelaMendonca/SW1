namespace Prestacao;
class contratopessoajuridica: Contratados
{
    public override double calcularPrestacao()
    {

        return base.calcularPrestacao()+ 3;
        
    }
}