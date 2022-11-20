namespace taxonomiaCSharp.mundoAnimal;

public class Peixe : Aquatico, Oviparo
{

    public void BotarOvo()
    {
        Console.WriteLine("Coloquei um ovo.");
    }

    public void Chocar()
    {
        Console.WriteLine("Estou chocando um ovo.");
    }

    public Peixe(string especie = "", string nome = "", int idade = 0, string ordem = "Omnívoro") : base(especie, nome, idade, ordem) { }
}