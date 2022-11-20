namespace taxonomiaCSharp.mundoAnimal;

public class Anfibio : Terrestre, Oviparo
{
    public void Pular()
    {
        Console.WriteLine("Estou pulando.");
    }

    public override void Andar()
    {
        Console.WriteLine("Estou andando em 4 patas.");
    }

    public void BotarOvo()
    {
        Console.WriteLine("Coloquei um ovo.");
    }

    public void Chocar()
    {
        Console.WriteLine("Estou chocando um ovo.");
    }

    public Anfibio(string especie = "", string nome = "", int idade = 0, string ordem = "Omnívoro") : base(especie, nome, idade, ordem) { }
}