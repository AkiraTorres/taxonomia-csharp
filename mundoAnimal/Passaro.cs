namespace taxonomiaCSharp.mundoAnimal;

public class Passaro : Animal, Aves
{
    public void Bicar()
    {
        Console.WriteLine("Estou bicando.");
    }

    public void Voar()
    {
        Console.WriteLine("Estou voando.");
    }

    public Passaro() : base() { }
    public Passaro(string especie) : base(especie) { }
    public Passaro(string especie, string nome) : base(especie, nome) { }
}