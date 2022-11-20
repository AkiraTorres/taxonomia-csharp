namespace taxonomiaCSharp.mundoAnimal;

public abstract class Animal
{
    public string? Nome { get; set; }
    public string? Especie { get; set; }
    public string? Habitat { get; set; }
    public int Idade { get; set; }

    public Animal() { }

    public Animal(string especie)
    {
        this.Especie = especie;
    }

    public Animal(string especie, string nome)
    {
        this.Especie = especie;
        this.Nome = nome;
    }

    public void Andar()
    {
        Console.WriteLine("Estou andando.");
    }

    public void Respirar()
    {
        Console.WriteLine("Estou respirando");
    }
}