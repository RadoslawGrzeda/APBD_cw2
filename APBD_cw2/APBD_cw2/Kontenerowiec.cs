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

    public Kontenerowiec(double maxPredkosc, int maxLiczbaKonetenerow,
        double maxWagaKontenerow)
    {
        this.maxPredkosc = maxPredkosc;
        this.maxLiczbaKonetenerow = maxLiczbaKonetenerow;
        this.maxWagaKontenerow = maxWagaKontenerow;
    }

    private List<Kontener> kontenerwoiec = new List<Kontener>();

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

    public void UsunKontener(Kontener kontener)
    {
        if (kontenerwoiec.Contains(kontener))
        {
            kontenerwoiec.Remove(kontener);


            maxWagaKontenerow -= (kontener.masa + kontener.masaWlasna);
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

    

    public void  OStatku()
    {
        Console.WriteLine(
            $"Kontenerowiec: kontenerow {naPokladzie}, o wadze {aktualnaWaga}");
        foreach (var variable in kontenerwoiec)
        {
            Console.WriteLine(variable);
        }

}
}