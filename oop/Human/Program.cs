using System;

namespace Human
{
    class Human
{
    // Fields for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    private int health;
     
    public int hetHealth(){return health;}

    public Human(string name)
    {
        Name = name;
        Strength = 5;
        Intelligence = 5;
        Dexterity = 5;
        health = 100;
    }
    public Human(string name, int stren, int intel, int dex)
    {
        Name = name;
        Strength = stren;
        Intelligence = intel;
        Dexterity = dex;
        health = 100;
    }

    public void Attack(Human tar)
    {
        var tarr = (Human) tar;
        tarr.health -= 5* Strength;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Attack!! {tarr.Name} losses {5*Strength} health points!");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"Stats: \n{tarr.Name} \n{tarr.health} \n{tarr.Dexterity} \n{tarr.Intelligence} \n{tarr.Strength}");
    
    }
    
}

    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Human("Bryan");
            var p2 = new Human("Kirill", 2,-9,4);
            p1.Attack(p2);
        }
    }
}
