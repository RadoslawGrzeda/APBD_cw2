using System.Reflection.Metadata.Ecma335;

namespace APBD_cw2;

public class Kontener
{
    private static char Type = 'K';
    private static int counter = 1;
    public double masa { get; set; } = 0;
    public double masaWlasna { get; set; }
    public double wysokosc { get; } = 0;
    public string numerSeryjny { get; }

    public void Dotankuj(double mas) 
    {
        this.masa += mas;
        if (this.masa > this.maksymalnaLadownosc)
            throw new OverfillException("Przeciążony");
    }

    public double wysokoscWlasna { get; set; }

    public double maksymalnaLadownosc { get; set; }

    public Kontener(double masaWlasna, double wysokoscWlasna, double maksymalnaLadownosc)
    {
        this.masaWlasna = masaWlasna;
        this.wysokoscWlasna = wysokoscWlasna;
        this.maksymalnaLadownosc = maksymalnaLadownosc;
        numerSeryjny = "KON-" + Type + '-' + counter.ToString();
        counter++;
    }

    public void OproznijKontener()
    {
        this.masa = 0;
    }
}