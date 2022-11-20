namespace taxonomiaCSharp.mundoAnimal;

public class Felino : Terrestre, Viviparo
{
    public void Miar()
    {
        Console.WriteLine("Estou miando.");
    }

    public void Ronronar()
    {
        Console.WriteLine("Estou ronronando.");
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

    public Felino(string especie = "", string nome = "", int idade = 0, string ordem = "Carnívoro") : base(especie, nome, idade, ordem) { }
}