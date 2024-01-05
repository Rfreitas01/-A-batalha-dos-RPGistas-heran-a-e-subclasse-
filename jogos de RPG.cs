using System;

public class Personagem
{
    public string Nome { get; set; }
    public int Mana { get; set; }

    public Personagem(string nome, int mana)
    {
        Nome = nome;
        Mana = mana;
    }
}

public class Subclasse : Personagem
{
    public int DanoBase { get; set; }

    public Subclasse(string nome, int mana, int danoBase) : base(nome, mana)
    {
        DanoBase = danoBase;
    }

    public int CalcularDano(int manaUsada)
    {
        return DanoBase * manaUsada;
    }
}

class Program
{
    static void Main(string[] args)
    {
        string nome = Console.ReadLine();
        int mana = int.Parse(Console.ReadLine());
        int danoBase = int.Parse(Console.ReadLine());

        Subclasse subclasse = new Subclasse(nome, mana, danoBase);
        int dano = subclasse.CalcularDano(mana);

        Console.WriteLine($"{nome} atacou e causou {dano} de dano!");
    }
}
