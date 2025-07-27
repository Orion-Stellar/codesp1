using System;

public class Enemigo
{
    public string Nombre;
    public int Vida;

    public Enemigo(string nombre, int vida)
    {
        Nombre = nombre;
        Vida = vida;
    }

    public virtual void Atacar()
    {
        Console.WriteLine(Nombre + " ataca con un golpe básico.");
    }
}

public class EnemigoVolador : Enemigo
{
    public EnemigoVolador(string nombre, int vida) : base(nombre, vida)
    {
    }

    public override void Atacar()
    {
        Console.WriteLine(Nombre + " lanza un ataque desde el aire.");
    }
}

public class EnemigoFelino : Enemigo
{
    public EnemigoFelino(string nombre, int vida) : base(nombre, vida)
    {
    }

    public override void Atacar()
    {
        Console.WriteLine(Nombre + " rasguña desde atrás.");
    }
}

public class EnemigoDebil : Enemigo
{
    public EnemigoDebil(string nombre, int vida) : base(nombre, vida)
    {
    }

    public override void Atacar()
    {
        Console.WriteLine(Nombre + " te da un manotazo.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Enemigo orco = new Enemigo("Orco", 100);
        EnemigoVolador murcielago = new EnemigoVolador("Murciélago", 50);
        EnemigoFelino puma = new EnemigoFelino("Puma", 70);
        EnemigoDebil slime = new EnemigoDebil("Slime", 20);

        orco.Atacar();      
        murcielago.Atacar();
        puma.Atacar();        
        slime.Atacar();     
    }
}
