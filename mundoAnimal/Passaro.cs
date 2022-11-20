namespace taxonomiaCSharp.mundoAnimal;

public class Passaro : Voador, Oviparo
{
    public void Bicar()
    {
        Console.WriteLine("Estou bicando.");
    }

    public void BotarOvo()
    {
        Console.WriteLine("Coloquei um ovo.");
    }

    public void Chocar()
    {
        Console.WriteLine("Estou chocando um ovo.");
    }

    public Passaro(string especie = "", string nome = "", int idade = 0, string ordem = "Omnívoro") : base(especie, nome, idade, ordem) { }

}