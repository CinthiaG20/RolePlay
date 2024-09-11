namespace Library;

public class Spell
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private int attackValue;
    public int AttackValue
    {
        get { return attackValue; }
        set { attackValue = value; }
    }

    private int defenseValue;
    public int DefenseValue
    {
        get { return defenseValue; }
        set { defenseValue = value; }
    }

    public Spell(string name, int attackValue, int defenseValue)
    {
        this.Name = name;
        this.AttackValue = attackValue;
        this.DefenseValue = defenseValue;
    }
}