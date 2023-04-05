namespace exemplo;
class Aluno
{
 public string nome = "";

 public double nota1, nota2;

    //Media
    public double obtermedia(){
    double media = (nota1+nota2)/2;
    return media;
 }

 public string obtersituacao(double media){
    string situacao = "";
    if (media>=6){
        situacao = "Aprovado";

    }else{
        situacao = "Reprovado";
    }
    return situacao;
    }

    public void mensagem(){
    double mediacalculada = obtermedia();
    string resultadosituacao = obtersituacao(mediacalculada);
    Console.WriteLine(nome + " está " + resultadosituacao+ " com média " + mediacalculada);
}


}


