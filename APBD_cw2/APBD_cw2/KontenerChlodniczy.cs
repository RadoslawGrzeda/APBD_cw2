namespace APBD_cw2;
using System.Collections.Generic;

public class KontenerChlodniczy : Kontener
{
    private Dictionary<string, double> hashMap = new Dictionary<string, double>
    {
        { "Banan", 13.3 },
        { "Czekolada", 18 },
        { "Ryba", 2 },
        { "Mięso", -15 },
        { "Lody", -18 },
        { "PizzaMrozona", -30 },
        { "Ser", 7.2 },
        { "Parowki", 5 },
        { "Maslo", 20.5 },
        { "Jajka", 19 }

    };
    protected string rodzajProduktu { get; set; }
    protected double temperatura { get; set; }
    protected static int counter = 1;
    protected static char Type = 'C';
    public KontenerChlodniczy
    (string rodzajProduktu,double temperatura,double masaWlasna, double wysokoscWlasna, 
    double maksymalnaLadownosc, double glebokosc) : base(masaWlasna, wysokoscWlasna, maksymalnaLadownosc, glebokosc)
    {
        this.rodzajProduktu = rodzajProduktu;
        this.temperatura = temperatura;
       foreach (var para in hashMap)
        {
          
            if (para.Key.ToUpper() == rodzajProduktu.ToUpper())
            {
                if (para.Value > temperatura || para.Value < temperatura)
                {
                    throw new Exception("NieZgadzajacaSieTemperatura");
                }
                
            }
        }
            numerSeryjny = "KON-" + Type + '-' + counter.ToString();
            counter++;
            
    }
    
}