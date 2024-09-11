namespace Library;

public class Spell
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    
    private int damage;
    public int Damage
    {
        get { return damage; }
        set { damage = value; }
    }

    public Spell(string name, int attackValue, int defenseValue)
    {
        this.Name = name;
        this.Damage = attackValue; ;
    }
}