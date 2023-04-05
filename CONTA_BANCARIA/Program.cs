namespace CONTA_BANCARIA;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercício Conta Bancária - ETECMCM");
        Conta conta = new Conta();

        conta.nomecliente = "Andernson Vanin";

        conta.limite = 500;

        conta.depositar(200);

        conta.sacar(50);
        
        //vamos chamr o metódo ConsultaSaldo e receber em uma variável local chamada saqldo o valor disponível em saldo desse cliente.
        double saldo = conta.ConsultaSaldo();
        //Agora para visualizar:
        Console.WriteLine("Seu saldo é de: " + saldo);
    }
}
