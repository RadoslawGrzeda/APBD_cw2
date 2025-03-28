// See https://aka.ms/new-console-template for more information


using APBD_cw2;

        try
        {
            Kontenerowiec ship = new Kontenerowiec("Statek 1", 10, 100, 40000);
            Console.WriteLine("Utworzono kontenerowiec:");
            ship.OStatku();
            
            KontenerNaPlyny milkContainer = new KontenerNaPlyny(false, 2000, 250, 5000, 300);
            KontenerNaGaz heliumContainer = new KontenerNaGaz(1000, 200, 3000, 200);
            KontenerChlodniczy bananaContainer = new KontenerChlodniczy("Banan", 13.3, 1500, 300, 4000, 250);
            
            milkContainer.Zaladowanie(1800);
            heliumContainer.Zaladowanie(500);
            bananaContainer.Zaladowanie(1200);
            
            ship.zaladuj(milkContainer);
            ship.zaladuj(heliumContainer);
            ship.zaladuj(bananaContainer);
            
            Console.WriteLine("Załadowano kontenery na statek.");
            ship.OStatku();
            
            milkContainer.OproznijKontener();
            heliumContainer.OproznijKontener();
            
            Console.WriteLine("Kontenery opróżnione.");
            ship.OStatku();
            
            try
            {
                milkContainer.Zaladowanie(2500); 
                milkContainer.Zaladowanie(2500);
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Błąd załadunku: " + e.Message);
            }
            
            Kontenerowiec ship2 = new Kontenerowiec("Statek 2", 12, 150, 50000);
            Kontenerowiec.PrzeniesLadunek(ship, ship2, milkContainer);
            
            Console.WriteLine("Kontener przeniesiony na drugi statek.");
            ship2.OStatku();
        }
        catch (Exception e)
        {
            Console.WriteLine("Wystąpił błąd: " + e.Message);
        }
    