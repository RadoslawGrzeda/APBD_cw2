namespace APBD_cw2;

public class Kontener
{
    private char Type = 'K';
    private double masa=0;
    private double wysokosc=0;
    private double masaWlasna;
    private double wysokoscWlasna;
    private string numerSeryjny;
    private double maksymalnaLadownosc;
    private static int counter = 1;

    public Kontener(double masaWlasna,double wysokoscWlasna,double maksymalnaLadownosc)
    {  
        this.masaWlasna = masaWlasna;
        this.wysokoscWlasna = wysokoscWlasna;
        this.maksymalnaLadownosc = maksymalnaLadownosc;
        this.numerSeryjny = "KON-" + this.Type +'-'+ counter.ToString();
    }

    public string getNumerSeryjny()
    {
        get 
    }