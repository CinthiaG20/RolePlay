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

Dwarve p1 = Dwarve ("bogar", 10);
Console.WriteLine(p1.Health);
Console.WriteLine(p1.Name);
Console.WriteLine(p1.MaxHealth);
Console.WriteLine(p1.TotalDamage());
Console.WriteLine(p1.TotalDefense());
        


