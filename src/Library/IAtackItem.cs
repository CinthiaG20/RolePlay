namespace Library;

public interface IAtackItem : IItem
{
    private string name;
    private int attackValue;
    
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    
    public int AttackValue
    {
        get { return attackValue; }
        set { attackValue = value; }
    }
}