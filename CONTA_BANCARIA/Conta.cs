namespace CONTA_BANCARIA;
class Conta
{
    public string? nomecliente {get;set;}
    public int numeroConta {get;set;}
    public double saldo {get;set;}
    public double limite {get;set;}

    //Método para realizar um depósito

    public void depositar(double valor){
        this.saldo += valor;
    }

    //Método para realizar um depósito
    public double ConsultaSaldo(){
        return this.saldo + this.limite;
    }

//Método para realizar um saque
        public void sacar (double valor){
        this.saldo = valor;
    }

}

