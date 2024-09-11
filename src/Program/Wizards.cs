namespace Library;

using System.Collections;

public class Wizard
{
    private string name;
    private int vida;
    private int initialVida;
    private ArrayList items = new ArrayList();

    public Wizard(string name, int vida)
    {
        this.name = name;
        this.vida = vida;
        this.initialVida = vida;
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
    public void Attack(Wizard target)
    {
        int damage = this.TotalDamage();
        target.ReceiveDamage(damage);
        Console.WriteLine($"{this.name} ataca a {target.name} y causa {damage} de daño.");
    }

    public void ReceiveDamage(int damage)
    {
        this.vida -= damage;
        if (this.vida < 0) this.vida = 0; // Ensure vida doesn't go below 0
        Console.WriteLine($"{this.name} recibe {damage} de daño. Vida restante: {this.vida}");
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
        return info;
    }
}