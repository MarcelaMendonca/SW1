namespace exemplo_acessor;
class Produto
{
    public string? Nome {get;set;}
    public double Preco {get;set;}

    public void MostraDados(){
        Console.WriteLine("Nome: " + this.Nome);
        Console.WriteLine("Preço:" + this.Preco);
    }
    public void AlteraPreco(double preco){
        if(preco >= 0){
            this.Preco = preco;
        }else{
            Console.WriteLine("Valor Invalido!");
        }
        
    }
    public void AlteraNome(string nome){
        this.Nome = nome;
    }
}