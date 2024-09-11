using System;

namespace RoleplayGame;

public class Program
{
    static void Main()
    {
        Dwarves p1 = new Dwarves("bogar", 10);
        Console.WriteLine(p1.Health);
        Console.WriteLine(p1.Name);
        Console.WriteLine(p1.MaxHealth);
        Console.WriteLine(p1.TotalDamage());
        Console.WriteLine(p1.TotalDefense());
        
    }
}
