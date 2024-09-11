using Library;

Wizard mago = new Wizard("Gandalf", 100);
Item baston = new Item("Bastón Mágico", 10, 3);
Item capa = new Item("Capa Mágica", 0, 10);
mago.AddItem(baston);
mago.AddItem(capa);

Wizard mago1 = new Wizard("Sauron", 100);
Item bastonigneo = new Item("Bastón de Fuego", 10, 3);
Item capain = new Item("Capa de Sigilo", 0, 10);
mago1.AddItem(bastonigneo);
mago1.AddItem(capain);
Console.WriteLine(mago.GetInfo());
Console.WriteLine(mago1.GetInfo());
mago.Attack(mago1);
mago1.Heal();


