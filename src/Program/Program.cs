namespace Library;

class Program
{
    static void Main() //inicia el programa
    {
        Wizard m1 = new Wizard("gandalf", 10);
        Console.WriteLine(m1.GetInfo());
        Spell s1 = new Spell("rayo", 15);
        SpellTome l1 = new SpellTome("Grimorio", 1, 0);
        Console.WriteLine(m1.GetInfo());
        l1.AddSpell(s1);
        m1.AddItem(l1);
        Console.WriteLine(m1.GetInfo());
        
        

    }
}