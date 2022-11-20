// See https://aka.ms/new-console-template for more information

namespace taxonomiaCSharp.mundoAnimal;

class Program
{
    public static void Main(string[] args)
    {
        TestarHumano();

        TestarFelino();

        TestarCanideo();

        TestarRoedor();

        TestarPassaro();

        TestarPeixe();

        TestarReptil();

        TestarAnfibio();
    }

    public static void TestarHumano()
    {
        Console.WriteLine("\n---Testando Humano---");
        Humano pessoa = new Humano("Funalo", 21);

        Console.WriteLine(pessoa.Nome);
        Console.WriteLine(pessoa.Idade);
        Console.WriteLine(pessoa.Ordem);

        pessoa.Respirar();
        pessoa.Dormir();
        pessoa.Pensar();
        pessoa.Falar();
        pessoa.Andar();
        pessoa.Gravidez();
        pessoa.Parir();
    }

    public static void TestarFelino()
    {
        Console.WriteLine("\n---Testando Felino---");
        Felino gato = new Felino("gato");

        Console.WriteLine(gato.Especie);

        gato.Miar();
        gato.Ronronar();
        gato.Andar();
    }

    public static void TestarCanideo()
    {
        Console.WriteLine("\n---Testando Canídeo---");
        Canideo cachorro = new Canideo("cachorro");

        Console.WriteLine(cachorro.Especie);

        cachorro.Latir();
        cachorro.Ronsnar();
        cachorro.Farejar();
        cachorro.Andar();
    }

    public static void TestarRoedor()
    {
        Console.WriteLine("\n---Testando Roedor---");
        Roedor rato = new Roedor("rato");

        Console.WriteLine(rato.Especie);

        rato.Roer();
        rato.Chiar();
        rato.Andar();
        rato.Cozinhar();
    }

    public static void TestarPassaro()
    {
        Console.WriteLine("\n---Testando Passaro---");
        Passaro passaro = new Passaro("gaivota");

        Console.WriteLine(passaro.Especie);

        passaro.Bicar();
        passaro.Voar();
        passaro.Pousar();
        passaro.Andar();
        passaro.BotarOvo();
        passaro.Chocar();
    }

    public static void TestarPeixe()
    {
        Console.WriteLine("\n---Testando Peixe---");
        Peixe px = new Peixe("tilápia");

        Console.WriteLine(px.Especie);

        px.Nadar();
        px.BotarOvo();
        px.Chocar();
    }

    public static void TestarReptil()
    {
        Console.WriteLine("\n---Testando Reptil---");
        Reptil sn = new Reptil("cobra");

        Console.WriteLine(sn.Especie);

        sn.Andar();
        sn.Nadar();
    }

    public static void TestarAnfibio()
    {
        Console.WriteLine("\n---Testando Anfíbio---");
        Anfibio sp = new Anfibio("sapo");

        Console.WriteLine(sp.Especie);

        sp.Pular();
        sp.Nadar();
    }
}