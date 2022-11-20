namespace taxonomiaCSharp.mundoAnimal;

public class Gato : Animal
{
    public void Miar()
    {
        Console.Write("Estou miando.");
    }

    public Gato() : base() { }
    public Gato(string especie) : base(especie) { }
    public Gato(string especie, string nome) : base(especie, nome) { }
}