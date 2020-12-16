using System;

public class Tamagotchi
{
   internal int hambre;
   internal int cansancio;
   internal int aburrimiento;
   internal int piedraVida;
    internal string nombreTamagotchi;
   

    public Tamagotchi(int hambre, int cansancio, int aburrimiento,  int piedraVida, string nombreTamagotchi)
    {
        this.hambre = hambre;
        this.cansancio = cansancio;
        this.aburrimiento = aburrimiento;
        this.piedraVida = piedraVida;
        this.nombreTamagotchi = nombreTamagotchi;
        Console.WriteLine("Tu tamagochi esta en las siguientes condiciones: ");
    }

    public int Hambre { get; set; }
    public int Cansancio{ get; set; }
    public int Aburrimiento { get; set; }
}