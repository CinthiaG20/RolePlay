using Library;

Dwarf enano = new Dwarf("Gimli", 100);

SpellTome SangreDracarica = new SpellTome("Sangre Dracárica", 0, 0);
Spell bolaDeFuego = new Spell("Bola de Fuego", 20);
Spell llamarada = new Spell("Llamarada", 15);

SangreDracarica.AddSpell(bolaDeFuego);
SangreDracarica.AddSpell(llamarada);

Wizard mago = new Wizard("Gandalf", 100, SangreDracarica);
Item baston = new Item("Bastón Mágico", 10, 3);
Item capa = new Item("Capa Mágica", 0, 10);

mago.AddItem(baston);
mago.AddItem(capa);

SpellTome CorazonHelado = new SpellTome("Corazón Helado", 0, 0);
Spell Nevada = new Spell("Tormenta de Nieve", 20);
Spell picosH = new Spell("Picos Helados", 15);

CorazonHelado.AddSpell(Nevada);
CorazonHelado.AddSpell(picosH);

Wizard mago1 = new Wizard("Sauron", 100, CorazonHelado);
Item bastonGigante = new Item("Bastón de Hielo", 10, 3);
Item capain = new Item("Capa de Sigilo", 0, 10);

mago1.AddItem(bastonGigante);
mago1.AddItem(capain);

mago.Attack(enano);
mago.UseSpell(bolaDeFuego, enano);
mago1.UseSpell(Nevada, mago);