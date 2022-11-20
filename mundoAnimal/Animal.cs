namespace taxonomiaCSharp.mundoAnimal;

public abstract class Animal
{
    public string Nome { get; protected set; }
    public string Ordem { get; protected set; }
    public string? Especie { get; protected set; }
    public int Idade { get; protected set; }

    public void Respirar()
    {
        Console.WriteLine("Estou respirando.");
    }

    public void Dormir()
    {
        Console.WriteLine("Estou dormindo.");
    }

    public Animal(string nome, int idade, string ordem)
    {
        this.Nome = nome;
        this.Idade = idade;
        this.Ordem = ordem;
    }

    public Animal(string especie, string nome, int idade, string ordem)
    {
        this.Especie = especie;
        this.Nome = nome;
        this.Idade = idade;
        this.Ordem = ordem;
    }
}