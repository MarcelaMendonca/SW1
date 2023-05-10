namespace Animal;

class Homem: Animal
{
    public override string Fala()
    {
        return base.Fala() + "Oie";
    }
                           
}