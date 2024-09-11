namespace Library;

using System.Collections;

public class Wizard
{
    private string name;
    private int vida;
    private ArrayList items = new ArrayList();

    public Wizard(string name, int vida)
    {
        this.name = name;
        this.vida = vida;
    }

    public void AddItem(object item)
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

    public void RemoveItem(object item)
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

    public Item GetItemByName(string nombre)
    {
        foreach (Item item in this.items)
        {
            if (item.Name == nombre)
            {
                return item;
            }
        }

        return null;
    }
}