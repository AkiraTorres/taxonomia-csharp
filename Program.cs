// See https://aka.ms/new-console-template for more information

namespace taxonomiaCSharp.mundoAnimal;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Passaro p = new Passaro("Passaro");

        p.Voar();
        p.Bicar();
    }
}