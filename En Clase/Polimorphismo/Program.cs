/* 
El chihuahua es un perro agresivo, mientras que el pomeranian no lo es.
Por eso, el chihuahua tiene las habilidades de morder y arrunar.
El pomeranian no tiene esas habilidades.
*/

Chihuahua chihuahuaHenry = new Chihuahua();
Pomeranian pomeranianHarry = new Pomeranian();

Console.WriteLine($"Chihuahua Henry\n\tHabilidades:\n\t\tLadrar:{chihuahuaHenry.ladrar()}\n\t\tDormir:{chihuahuaHenry.Dormir()}\n\t\tArrunar:{chihuahuaHenry.Arrunar()}\n\t\tMorder:{chihuahuaHenry.Morder()}");
Console.WriteLine($"Pomeranian Harry\n\tHabilidades:\n\t\tLadrar:{pomeranianHarry.ladrar()}\n\t\tDormir:{pomeranianHarry.Dormir()}");