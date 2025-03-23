// See https://aka.ms/new-console-template for more information

using APBD_cw2;

// Console.WriteLine("Hello, World!");
// Kontener kontener=new Kontener(1000,1000,10010);
// Console.WriteLine(kontener);
// Console.WriteLine(kontener.masa);
// Console.WriteLine(kontener.numerSeryjny);
// Kontener kontener2 = new Kontener(1000,1000,10010);
// Console.WriteLine(kontener2.numerSeryjny);
// try
// {
//     Kontener kon3 = new Kontener(1000, 21, 20);
//     Console.WriteLine(kon3.masa);
//     kon3.Dotankuj(10);
//     kon3.Dotankuj(10);
//     Console.WriteLine(kon3.masa);
//     kon3.Dotankuj(3);
//     Console.WriteLine(kon3.masa);
//     // kon3.Dotankuj(3);
// }
// catch (OverfillException e)
// { 
//     Console.WriteLine(e);
// }

KontenerNaPlyny konNa1 = new KontenerNaPlyny(false,1000,1000,20);
try
{
    konNa1.Dotankuj(10);
    Console.WriteLine(konNa1.masa);
    konNa1.Dotankuj(7);
}
catch (OverfillException e)
{
    Console.WriteLine(e);
}