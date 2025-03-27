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
//
// KontenerNaPlyny konNa1 = new KontenerNaPlyny(false,100,1000,1000,20);
// try
// {
//     konNa1.Dotankuj(10);
//     Console.WriteLine(konNa1.masa);
//     konNa1.Dotankuj(7);
// }
// catch (OverfillException e)
// {
//     Console.WriteLine(e);
// }

KontenerChlodniczy kon=new KontenerChlodniczy("baNan",13.3,5,10,10,10);
KontenerChlodniczy ko2=new KontenerChlodniczy("baNan",13.3,10,10,10,10);
// KontenerChlodniczy ko3=new KontenerChlodniczy("baNan",13.3,10,10,10,10);
KontenerNaGaz konNaGaz = new KontenerNaGaz(100, 10, 1000, 10);
KontenerNaPlyny kontNaPlyny = new KontenerNaPlyny(100, 10, 1000, 10);


Kontenerowiec konten = new Kontenerowiec("Konten1",12, 4, 2112);
Kontenerowiec konten2 = new Kontenerowiec("Konten2",12, 4, 2112);

konten.zaladuj(kon);
konten.zaladuj(ko2);
konten.zaladuj(konNaGaz);

konten.OStatku();
Console.WriteLine();
konten2.zaladuj(konNaGaz);
konten2.zaladuj(kontNaPlyny);
konten2.OStatku();

Kontenerowiec.PrzeniesLadunek(konten,konten2,kon);
Console.WriteLine("============================");


konten.OStatku();
Console.WriteLine();

konten2.OStatku();
// konten.zaladuj(ko2);
// Console.WriteLine(kon.ToString());
// Console.WriteLine(ko2.ToString());
// Console.WriteLine(kon.ToString());
// kon.Dotankuj(5);
// konten.zaladuj(kon);
//
// Console.WriteLine();
// Console.WriteLine(konten.aktualnaWaga);
// Console.WriteLine(konten.naPokladzie);
// konten.ZastapKontener("KON-C-1",ko3);
// konten.OStatku();
// try
// {
//  // ?   kon.Dotankuj(11);
//     // kon.Dotankuj(10);
//     // Console.WriteLine(kon.masa);
//     Console.WriteLine(kon.numerSeryjny);
//     Console.WriteLine(ko2.numerSeryjny);
// }
// catch (OverfillException e)
// {
//     Console.WriteLine(e.Message);
// }
