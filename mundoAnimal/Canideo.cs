namespace taxonomiaCSharp.mundoAnimal;

public class Canideo : Terrestre, Viviparo
{
    public void Latir()
    {
        Console.WriteLine("Estou latindo.");
    }

    public void Ronsnar()
    {
        Console.WriteLine("Estou ronsnando.");
    }

    public void Farejar()
    {
        Console.WriteLine("Estou farejando.");
    }

    public override void Andar()
    {
        Console.WriteLine("Estou andando em 4 patas.");
    }

    public void Gravidez()
    {
        Console.WriteLine("Estou gestando uma gravidez.");
    }

    public void Parir()
    {
        Console.WriteLine("Estou parindo.");
    }

    public Canideo(string especie = "", string nome = "", int idade = 0, string ordem = "Carnívoro") : base(especie, nome, idade, ordem) { }
}