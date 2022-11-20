namespace taxonomiaCSharp.mundoAnimal;

public abstract class Aquatico : Animal
{
    public void Nadar()
    {
        Console.WriteLine("Estou nadando.");
    }

    public Aquatico(string especie, string nome, int idade, string ordem) : base(especie, nome, idade, ordem) { }

}