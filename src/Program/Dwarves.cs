namespace RoleplayGame;

public class Dwarves
{
    private string name;            //atributo nombre
    public string Name              //metodo para poner o saber nombre
    {
        get { return name;}
        set { name = value;}
    }
    
    private int maxhealth;          //atributo vida maxima
    public int MaxHealth               //metodo vida maxima
    {
        get { return maxhealth;}
        set { maxhealth = value;}
    }
    private int health;             //atributo vida (actual)
    public int Health               //metodo vida
    {
        get { return health;}
        set { health = value;}
    }
    
    private Inventory inventory = new Inventory();      //atributo lista de objetos

    public int TotalDamage()                //Metodo Daño total
    {
        int totalatk = 0;       //inicia una variable
        foreach (Item item in inventory)    //suma al ataque total todos los valores de ataque de los items
        {
            totalatk += inventory.item.Atk;
        }
        return totalatk;        //devuelve el total
    }
    
    public int TotalDefense()               //Metodo Daño total
    {
        int totaldef = 0;       //inicia una variable
        foreach (Item item in inventory)    //suma a la defensa total todos los valores de defensa de los items
        {
            totaldef += inventory.item.Def;
        }
        return totaldef;        //devuelve la defensa total
    }

    public void Heal()          //metodo para curar
    {
        health = maxhealth;
    }

    public Dwarves(string name, int maxhealth)          //metodo creador
    {
        this.Name = name;                   //toma el string para el nombre
        this.MaxHealth = maxhealth;         //toma el entero dado para que sea la vida maxima
        this.Health = maxhealth;            //le da el mismo valor a la vida actual
    }
}