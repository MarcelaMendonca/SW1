namespace exemplo;
class Program
{
    static void Main(string[] args)
    
     {
        Aluno aluno1 = new Aluno();

        Console.WriteLine("Digite seu nome: ");
        string? nome = Console.ReadLine();
        Console.WriteLine("Seu nome é: " + nome);
        Console.Write("Digite um numero: ");
        aluno1.nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("O numero digitado foi: ");
        Console.Write("Digite um numero: ");
        aluno1.nota2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("O numero digitado foi: ");

        
        aluno1.mensagem();
    }
}