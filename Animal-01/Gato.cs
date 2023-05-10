namespace Animal;

class Gato:Animal
{
    public override string Fala()
    {
        return base.Fala() + "MiauMiauMiau";
    }
                           
}