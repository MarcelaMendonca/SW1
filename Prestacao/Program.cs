namespace Prestacao;
class Program
{
    static void Main(string[] args)
    {
        
        contratopessoafisica n1 = new contratopessoafisica();
        contratopessoajuridica n2 = new contratopessoajuridica();
        
        n1.Nome = "Angel";
        n1.Idade = "30";
        n1.Contrato = "100";

        n2.Nome = "Benjamim";
        n2.Idade = "40";
        n2.Contrato = "100";

        Console.WriteLine("Nome (fisico): " + n1.Nome + "Idade: " n1.Idade + "Contrato (valor): " + n1.Contrato + (n1.MostraDados()));
        Console.WriteLine("Nome (juridico): " + n2.Nome + "Idade: " n2.Idade + "Contrato (valor): " + n2.Contrato + (n1.MostraDados()));
        
    }
}