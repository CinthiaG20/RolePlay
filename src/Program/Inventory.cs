using System.Collections;

namespace Program;

public class Inventory
{
    private ArrayList inventory = new ArrayList();
    
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
}