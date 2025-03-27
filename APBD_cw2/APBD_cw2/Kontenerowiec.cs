using System.Collections;

namespace APBD_cw2;
using System.Collections.Generic;

public class Kontenerowiec
{
    protected double maxPredkosc { get; set; }
    protected int maxLiczbaKonetenerow { get; }
    protected double maxWagaKontenerow { get; set; }

    public int naPokladzie { get; set; } = 0;
    public double aktualnaWaga { get; set; } = 0;
    private string nazwa { get; set; }
    private List<Kontener> kontenerwoiec = new List<Kontener>();
    public Kontenerowiec(string nazwa,double maxPredkosc, int maxLiczbaKonetenerow,
        double maxWagaKontenerowWTonach)
    {
        this.nazwa = nazwa;
        this.maxPredkosc = maxPredkosc;
        this.maxLiczbaKonetenerow = maxLiczbaKonetenerow;
        this.maxWagaKontenerow = maxWagaKontenerowWTonach * 1000;
    }

    public void zaladuj(Kontener kontener)
    {
        double roznica = maxWagaKontenerow - aktualnaWaga;
        if (naPokladzie < maxLiczbaKonetenerow && roznica >= (kontener.masa + kontener.masaWlasna))
        {
            kontenerwoiec.Add(kontener);
            aktualnaWaga += (kontener.masa + kontener.masaWlasna);
            naPokladzie++;
        }
        else
        {
            Console.WriteLine("FULL");
        }
    }

    public  void zaladujKilka(List<Kontener> kontener)
    {
        foreach (var VARIABLE in kontener)
        {
            zaladuj(VARIABLE);
        }

    }



    public void UsunKontener(Kontener kontener)
    {
        if (kontenerwoiec.Contains(kontener))
        {
            kontenerwoiec.Remove(kontener);


            aktualnaWaga -= (kontener.masa + kontener.masaWlasna);
            naPokladzie--;

        }
        else
        {
            Console.WriteLine("NieMaZaladowanegoTakiegoKontenera");
        }
    }

    public void ZastapKontener(String numerKontenera, Kontener kontener2)
    {
        Kontener? kontener1 = null;
        foreach (var VARIABLE in kontenerwoiec)
        {
            if (VARIABLE.numerSeryjny == numerKontenera)
            {
                kontener1 = VARIABLE;
            }
        }

        if (kontener1 == null)
        {
            Console.WriteLine("NieMaTakiegoKontenera");
        }

        double roznica = maxWagaKontenerow - aktualnaWaga - (kontener1.masa + kontener1.masaWlasna);
        if (roznica >= (kontener2.masaWlasna + kontener2.masa))
        {

            kontenerwoiec.Remove(kontener1);
            aktualnaWaga -= (kontener1.masa + kontener1.masaWlasna);
            kontenerwoiec.Add(kontener2);
            aktualnaWaga += (kontener2.masa + kontener2.masaWlasna);
        }
        else
        {
            Console.WriteLine("ZamianaNiemozliwa");
        }
    }


    public static void PrzeniesLadunek(Kontenerowiec kon1, Kontenerowiec kon2, Kontener kon)
    {
        kon1.UsunKontener(kon);
        
        var roz = kon2.maxWagaKontenerow - kon2.aktualnaWaga;
        if ((kon.masa + kon.masaWlasna) <= roz)
        {
            kon2.zaladuj(kon);
            }
        else
        {
            Console.WriteLine("PrzeniesienieNiemozliwe");
        }

    }



public void  OStatku()
    {
        Console.WriteLine(
            $"Kontenerowiec:{nazwa},  kontenerow {naPokladzie}, o wadze {aktualnaWaga}");
        foreach (var variable in kontenerwoiec)
        {
            Console.WriteLine(variable);
        }

}
}