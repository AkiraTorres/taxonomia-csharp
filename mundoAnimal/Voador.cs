namespace taxonomiaCSharp.mundoAnimal;

public abstract class Voador : Animal
{
    public void Voar()
    {
        Console.WriteLine("Estou voando.");
    }

    public void Pousar()
    {
        Console.WriteLine("Estou pousando.");
    }

    public void Andar()
    {
        Console.WriteLine("Estou andando com duas patas.");
    }

    public Voador(string especie, string nome, int idade, string ordem) : base(especie, nome, idade, ordem) { }

}