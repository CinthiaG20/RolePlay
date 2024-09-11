using Library;

SpellBook SangreDracarica = new SpellBook();
Spell bolaDeFuego = new Spell("Bola de Fuego", 20);
Spell llamarada = new Spell("llamarda", 15);

SangreDracarica.AddSpell(bolaDeFuego);
SangreDracarica.AddSpell(llamarada);

Wizard mago = new Wizard("Gandalf", 100, SangreDracarica);
Item baston = new Item("Bastón Mágico", 10, 3);
Item capa = new Item("Capa Mágica", 0, 10);

mago.AddItem(baston);
mago.AddItem(capa);

SpellBook CorazonHelado = new SpellBook();
Spell Nevada = new Spell("Tormenta de nieve", 20);
Spell picosH = new Spell("Picos helados", 15);

CorazonHelado.AddSpell(Nevada);
CorazonHelado.AddSpell(picosH);

Wizard mago1 = new Wizard("Sauron", 100, CorazonHelado);
Item bastonGigante = new Item("Bastón de hielo", 10, 3);
Item capain = new Item("Capa de Sigilo", 0, 10);

mago1.AddItem(bastonGigante);
mago1.AddItem(capain);

mago.Attack(mago1);
mago1.Heal();

Console.WriteLine(mago.GetInfo());
Console.WriteLine(mago1.GetInfo());
