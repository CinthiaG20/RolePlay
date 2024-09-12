namespace Library;

using System.Collections;

public class Wizard : Chara
{
    private string name;
    private int health;
    private int maxhealth;
    private ArrayList items = new ArrayList();

    public Wizard(string name, int vida)
    {
        this.name = name;
        this.health = vida;
        this.maxhealth = vida;
    }

    public string Name
    {
        get { return name;}
        set { name = value; }
    }
    public int Health
    {
        get { return health;}
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
    public int TotalDamage()                //Metodo Daño total
    {
        int totalatk = 0;       //inicia una variabe
        foreach (Item item in this.items)
        {
            totalatk += item.AttackValue;
        }                               //suma al ataque total todos los valores de ataque de los items
        return totalatk;        //devuelve el total
    }
    
    public int TotalDefense()               //Metodo Daño total
    {
        int totaldef = 0;       //inicia una variable
        foreach (Item item in this.items)
        {
            totaldef += item.DefenseValue;
        }                          
        return totaldef;        //devuelve la defensa total
    }

    public void Attack(Chara target)
    {
        int damage = this.TotalDamage();
        target.ReceiveDamage(damage);
        Console.WriteLine($"{this.Name} ataca a {target.Name} y causa {damage} de daño.");
    }

    public void ReceiveDamage(int damage)
    {
        this.Health -= damage;
        if (this.Health < 0) this.Health = 0; // Ensure vida doesn't go below 0
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
        return info;
    }

    public void Cast(Spell castedspell, Chara target)
    {
        foreach (object item in items)
        {
            if (item is SpellTome)
            {
                foreach (Spell spell in item)
                {
                    if (castedspell == spell)
                    {
                        target.Health -= castedspell.Damage;
                        if (target.Health < 0) target.Health = 0; 
                        Console.WriteLine($"{target.Name} recibe {spell.Damage} de daño. Vida restante: {target.Health}");
                    }
                }
            }
        }
    }
}