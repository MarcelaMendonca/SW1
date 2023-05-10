namespace Animal;
class Program
{
    static void Main(string[] args)
    {
        Cao Thor = new Cao();
        Gato Kiara = new Gato();
        Homem Noah = new Homem();

        Console.WriteLine("Chamei o gato e ele: "+ Kiara.Fala());
        Console.WriteLine("Chamei o cachorro e ele: "+ Thor.Fala());
        Console.WriteLine("Chamei o homem e ele: "+ Noah.Fala());
    }
}
