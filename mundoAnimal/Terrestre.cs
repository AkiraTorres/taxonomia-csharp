namespace taxonomiaCSharp.mundoAnimal;

public abstract class Terrestre : Animal
{
    public abstract void Andar();

    public void Nadar()
    {
        Console.WriteLine("Estou nadando.");
    }

    public Terrestre(string nome, int idade, string ordem) : base(nome, idade, ordem) { }
    public Terrestre(string especie, string nome, int idade, string ordem) : base(especie, nome, idade, ordem) { }
}