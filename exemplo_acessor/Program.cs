namespace exemplo_acessor;
class Program
{
    static void Main(string[] args)
    {
        Produto p1 = new Produto();
        //p1.Preco = 20;
        p1.AlteraPreco(15);
        p1.AlteraNome("PARAFUSO");
        p1.MostraDados();

        //Console.WhiteLine("Gaveta: " + p1.Preco)
    }
}
