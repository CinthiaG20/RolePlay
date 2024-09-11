using Library;

Wizard mago = new Wizard("gandalf", 100);
Item baston=new Item("baston magico", 10, 3);
Item capa=new Item("capa magica", 0, 10);
mago.AddItem(baston);
mago.AddItem(capa);

Console.WriteLine(mago.GetInfo());


