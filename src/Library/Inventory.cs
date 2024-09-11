using System.Collections;

namespace Program;

public class Inventory : IEnumerable
{
    private ArrayList inventory = new ArrayList();

    public int ItemAmount()
    {
        return inventory.Count;
    }
    public void AddItem(object Item)                    //Metodo "Añadir objeto"
    {
            this.inventory.Add(Item);
    }

    public void RmvItem(object Item)                
    {
        if (Item != null)
        {
            this.inventory.Remove(Item);
        }
        else
        {
            Console.WriteLine("El personaje no tiene ese item");   
        }
    
    }
    public object this[int index]
    {
        get
        {
            if (index < 0 || index >= inventory.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Índice fuera del rango.");
            }
            return inventory[index];
        }
        set
        {
            if (index < 0 || index >= inventory.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Índice fuera del rango.");
            }
            inventory[index] = value;
        }
    }

    public IEnumerator GetEnumerator()
    {
        return inventory.GetEnumerator();
    }
}
