// See https://aka.ms/new-console-template for more information


using APBD_cw2;

{
    // Kontener kontener1 = new Kontener(2100, 300, 4000, 1000);
    
    
    // kontener1.Zaladowanie(200);
    // Console.WriteLine(kontener1);
    // kontener1.OproznijKontener();
    // Console.Write(kontener1);
    //
    KontenerNaPlyny kontener2 = new KontenerNaPlyny(2100, 300, 4000, 1000);
    Console.WriteLine(kontener2);
    kontener2.Zaladowanie(1600);
    Console.WriteLine(kontener2);
    
    KontenerNaGaz kontenerNaGaz = new KontenerNaGaz(2100, 300, 4000, 1000);
    Console.WriteLine(kontenerNaGaz);
    kontenerNaGaz.Zaladowanie(1600);
    Console.WriteLine(kontenerNaGaz);
}