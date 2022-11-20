namespace taxonomiaCSharp.mundoAnimal;

public class Humano : Terrestre, Viviparo
{
    public string? Cpf { get; private set; }

    public void Pensar()
    {
        Console.WriteLine("Estou pensando.");
    }

    public void Falar()
    {
        Console.WriteLine("Estou falando.");
    }

    public override void Andar()
    {
        Console.WriteLine("Estou andando em duas pernas.");
    }

    public void Gravidez()
    {
        Console.WriteLine("Estou gestando uma gravidez.");
    }

    public void Parir()
    {
        Console.WriteLine("Estou parindo.");
    }

    public Humano(string nome = "", int idade = 0, string ordem = "Omnívoro") : base(nome, idade, ordem) { }
}