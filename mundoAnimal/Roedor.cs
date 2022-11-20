namespace taxonomiaCSharp.mundoAnimal;

public class Roedor : Terrestre, Viviparo
{
    public void Roer()
    {
        Console.WriteLine("Estou roendo.");
    }

    public void Chiar()
    {
        Console.WriteLine("Estou chiando.");
    }

    public override void Andar()
    {
        Console.WriteLine("Estou andando em 4 patas.");
    }

    public void Cozinhar()
    {
        Console.WriteLine("Estou fazendo ratatouille.");
    }

    public void Gravidez()
    {
        Console.WriteLine("Estou gestando uma gravidez.");
    }

    public void Parir()
    {
        Console.WriteLine("Estou parindo.");
    }

    public Roedor(string especie = "", string nome = "", int idade = 0, string ordem = "Carnívoro") : base(especie, nome, idade, ordem) { }

}