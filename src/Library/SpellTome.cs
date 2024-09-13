using System.Collections;
using System.Collections.Generic;

using System.Collections;
using System.Collections.Generic;

namespace Library;

public class SpellTome : Item, IEnumerable<Spell>
{
    private List<Spell> spells = new List<Spell>();

    public SpellTome(string name, int attackValue, int defenseValue) :
        base(name, attackValue, defenseValue)
    {
    }

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

    public bool ContainsSpell(Spell spell)
    {
        return this.spells.Contains(spell);
    }

    public string GetSpellsInfo()
    {
        string info = "Hechizos:\n";
        foreach (Spell spell in this.spells)
        {
            info += $"- {spell.Name} (Ataque: {spell.Damage})\n";
        }
        return info;
    }

    public IEnumerator<Spell> GetEnumerator()
    {
        return this.spells.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}