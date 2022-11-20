namespace taxonomiaCSharp.mundoAnimal;

public class Reptil : Terrestre, Oviparo
{
    public override void Andar()
    {
        if (this.Especie == "cobra")
        {
            Console.WriteLine("Estou rastejando.");
        }
        else
        {
            Console.WriteLine("Estou andando em 4 patas.");
        }
    }

    public void BotarOvo()
    {
        Console.WriteLine("Coloquei um ovo.");
    }

    public void Chocar()
    {
        Console.WriteLine("Estou chocando um ovo.");
    }

    public Reptil(string especie = "", string nome = "", int idade = 0, string ordem = "Carnívoro") : base(especie, nome, idade, ordem) { }
}