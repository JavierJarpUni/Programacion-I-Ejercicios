Telefono telefono = new Telefono("Telefono1", "Iphone 15", 100, "809-030-2039");


telefono.Prender();
Console.WriteLine($"{telefono.GetCharge()}");
telefono.Apagar();

telefono.Llamar("809-040-7654");
telefono.Prender();
telefono.Llamar("809-040-7654");