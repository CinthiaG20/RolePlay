namespace Program;

public class Item
{
    private string name;
    public string Name
    {
        get { return name;}
        set { name = value;}
    }
    
    
    private int atk;
    public int Atk
    {
        get { return atk;}
        set { atk = value;}
    }
    private int def;
    public int Def
    {
        get { return def;}
        set { def = value;}
    }

    public Item(string name, int atk, int def)
    {
        this.Name = name;
        this.Atk = atk;
        this.Def = def;
    }
}