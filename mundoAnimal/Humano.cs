namespace taxonomiaCSharp.mundoAnimal;

public class Humano : Animal
{
    private string? Cpf { get; set; }

    public void Pensar()
    {
        Console.WriteLine("Estou pensando.");
    }

    public void Falar()
    {
        Console.WriteLine("Estou falando.");
    }

    public Humano() : base() { }
    public Humano(string especie) : base(especie) { }
    public Humano(string especie, string nome) : base(especie, nome) { }
}