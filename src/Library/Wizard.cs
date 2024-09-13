namespace Library;

using System.Collections;

public class Wizard : Chara
{
    private string name;
    private int health;
    private int maxhealth;
    private ArrayList items = new ArrayList();
    private SpellTome spellTome;

    public Wizard(string name, int vida, SpellTome spellTome)
    {
        this.name = name;
        this.health = vida;
        this.maxhealth = vida;
        this.spellTome = spellTome;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Health
    {
        get { return health; }
        set { health = value; }
    }
    public void AddItem(Item item)
    {
        if (item != null)
        {
            this.items.Add(item);
        }
        else
        {
            Console.WriteLine("Ese item no existe");
        }
    }
    public void RemoveItem(Item item)
    {
        if (item != null)
        {
            this.items.Remove(item);
        }
        else
        {
            Console.WriteLine("Ese item no existe");
        }
    }
    public int TotalDamage()
    {
        int totalatk = 0;
        foreach (Item item in this.items)
        {
            totalatk += item.AttackValue;
        }
        return totalatk;
    }
    
    public int TotalDefense()
    {
        int totaldef = 0;
        foreach (Item item in this.items)
        {
            totaldef += item.DefenseValue;
        }
        return totaldef;
    }

    public void Attack(Chara target)
    {
        int damage = this.TotalDamage();
        target.ReceiveDamage(damage);
        Console.WriteLine($"{this.Name} ataca a {target.Name} y causa {damage} de daño.");
    }

    public void UseSpell(Spell spell, Chara target)
    {
        if (this.spellTome.ContainsSpell(spell))
        {
            target.ReceiveDamage(spell.Damage);
            Console.WriteLine($"{this.name} usa {spell.Name} y causa {spell.Damage} de daño.");
        }
        else
        {
            Console.WriteLine($"{this.name} no conoce el hechizo {spell.Name}.");
        }
    }

    public void ReceiveDamage(int damage)
    {
        this.Health -= damage;
        if (this.Health < 0) this.Health = 0;
        Console.WriteLine($"{this.name} recibe {damage} de daño. Vida restante: {this.Health}");
    }

    public void Heal()
    {
        this.health = this.maxhealth;
        Console.WriteLine($"{this.name} ha sido curado. Vida restaurada a: {this.health}");
    }
    public string GetInfo()
    {
        string info = $"Nombre: {this.name}, Vida: {this.health}\nItems:\n";
        foreach (Item item in this.items)
        {
            info += $"- {item.Name} (Ataque: {item.AttackValue}, Defensa: {item.DefenseValue})\n";
        }
        info += $"Total Ataque: {this.TotalDamage()}\n";
        info += $"Total Defensa: {this.TotalDefense()}\n";
        info += this.spellTome.GetSpellsInfo();
        return info;
    }
}