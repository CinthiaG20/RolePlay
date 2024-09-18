namespace Library;

public interface IItem
{
    string Name { get; }
    private int defenseValue;
    public int DefenseValue
    {
        get { return defenseValue; }
        set { defenseValue = value; }
    }

    public Item(string name, int attackValue, int defenseValue)
    {
        this.Name = name;
        this.AttackValue = attackValue;
        this.DefenseValue = defenseValue;
    }
}