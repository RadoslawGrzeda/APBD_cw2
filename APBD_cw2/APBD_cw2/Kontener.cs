using System.Reflection.Metadata.Ecma335;

namespace APBD_cw2;

public class Kontener
{
    protected static int counter = 1;
    protected static char Type = 'K';

    public double masa { get; set; } = 0;
    public double masaWlasna { get; set; }
    public double wysokosc { get; } = 0;
    public double glebokosc { get; set; }
    public string numerSeryjny { get; set; }

    public virtual void Dotankuj(double mas) 
    {
        this.masa += mas;
        if (this.masa > this.maksymalnaLadownosc)
            throw new OverfillException("Przeciążony");
    }

    public double wysokoscWlasna { get; set; }

    public double maksymalnaLadownosc { get; set; }

    public Kontener(double masaWlasna, double wysokoscWlasna, double maksymalnaLadownosc,double glebokosc)
    {   this.glebokosc = glebokosc;
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