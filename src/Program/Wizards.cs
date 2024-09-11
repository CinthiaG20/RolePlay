namespace Library;

using System.Collections;

public class Wizard
{
    private string name;
    private int vida;
    private int initialVida;
    private ArrayList items = new ArrayList();
    private SpellBook spellBook;

    public Wizard(string name, int vida, SpellBook spellBook)
    {
        this.name = name;
        this.vida = vida;
        this.initialVida = vida;
        this.spellBook = spellBook; 
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

    public void Attack(Wizard target)
    {
        int damage = this.TotalDamage();
        target.ReceiveDamage(damage);
        Console.WriteLine($"{this.name} ataca a {target.name} y causa {damage} de daño.");
    }

    public void UseSpell(Spell spell, Wizard target)
    {
        if (this.spellBook.ContainsSpell(spell))
        {
            int damage = spell.AttackValue;
            Console.WriteLine($"{this.name} usa {spell.Name} en {target.name} y causa {damage} de daño.");
            target.ReceiveDamage(damage);
        }
        else
        {
            Console.WriteLine($"{this.name} no tiene el hechizo {spell.Name}.");
        }
    }

    public void ReceiveDamage(int damage)
    {
        this.vida -= damage;
        if (this.vida < 0) this.vida = 0;
        Console.WriteLine($"{this.name}  Vida restante: {this.vida}");
    }

    public void Heal()
    {
        this.vida = this.initialVida;
        Console.WriteLine($"{this.name} ha sido curado. Vida restaurada a: {this.vida}");
    }

    public string GetInfo()
    {
        string info = $"Nombre: {this.name}, Vida: {this.vida}\nItems:\n";
        foreach (Item item in this.items)
        {
            info += $"- {item.Name} (Ataque: {item.AttackValue}, Defensa: {item.DefenseValue})\n";
        }
        info += $"Total Ataque: {this.TotalDamage()}\n";
        info += $"Total Defensa: {this.TotalDefense()}\n";
        info += this.spellBook.GetSpellsInfo();
        return info;
    }
}