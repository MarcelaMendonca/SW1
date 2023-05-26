namespace Contratados;
class Program
{
    static void Main(string[] args)
    {
        contratopessoafisica n1 = new contratopessoafisica();
        contratopessoajuridica n2 = new contratopessoajuridica();

        n1.Nome = "Ember";
        n1.Idade = "28";
        n1.CPF = "698.700.833/08";

        n2.Nome = "Angel";
        n2.Empresa = "Angeltec";
        n2.IE = "25 576821";
        n2.CNPJ = "10. 890. 345/0008-25";

        Console.WriteLine("Nome (fisico) : " + n1.Nome + " Idade: " + n1.Idade + " CPF: " + n1.CPF + (n2.MostrarDados()));
        Console.WriteLine("Nome (juridico) : " + n2.Nome + " Empresa: " + n2.Empresa + " Inscrição estadual: " + n2.IE + " CNPJ: " + n2.CNPJ + (n2.MostrarDados()));
}
}