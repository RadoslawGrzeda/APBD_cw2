namespace APBD_cw2;

public class KontenerNaGaz : Kontener,IHazardNotifier
{
    protected static new int counter = 1;
    protected static new char Type = 'G';
    protected double cisninienie { get; set; }

    public KontenerNaGaz(double masaWlasna, double wysokoscWlasna, double maksymalnaLadownosc, double glebokosc) : base(
        masaWlasna, wysokoscWlasna, maksymalnaLadownosc, glebokosc)
    {
        
        numerSeryjny = $"KON-{Type}-{counter}";
        counter++;
    }
    
    public override void OproznijKontener()
    {
        this.masa *= 0.05;

    }

    public void DangerousSituation()
    {
        Console.WriteLine($"NiebezpiecznaSytuacjaWKontenerze: {numerSeryjny}");
    }

    public override void Zaladowanie(double mas)
    {
        var roz = maksymalnaLadownosc - masa;
        if (roz >= mas)
        {
            masa += mas;
        }
        else throw new OverfillException("BrakMiejsca");
    }
}