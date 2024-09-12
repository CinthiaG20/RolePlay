using System.Collections;

namespace Library;

public class SpellTome : Item
{
    // Lista de hechizos usando List<T>
    private List<Spell> spells = new List<Spell>();

    //private ArrayList spells = new ArrayList();
    
    public void AddSpell(Spell spell)
    {
        if (spell != null)
        {
            this.spells.Add(spell);
        }
        else
        {
            Console.WriteLine("Ese hechizo no existe");
        }
    }

    public void RemoveSpell(Spell spell)
    {
        if (spell != null)
        {
            this.spells.Remove(spell);
        }
        else
        {
            Console.WriteLine("Ese hechizo no existe");
        }
    }

    public SpellTome(string name, int attackValue, int defenseValue) :
        base(name,attackValue,defenseValue)
    {
    }
    
    public IEnumerator GetEnumerator() 
    { 
        return this.GetEnumerator(); 
    }
}
