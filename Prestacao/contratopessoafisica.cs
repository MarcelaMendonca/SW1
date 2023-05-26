namespace Prestacao;
class Contratados
{

    public double valorPrestacao{get;set;}
    
    public virtual double calcularPrestacao(){
        return valorPrestacao / 30;
    }
}