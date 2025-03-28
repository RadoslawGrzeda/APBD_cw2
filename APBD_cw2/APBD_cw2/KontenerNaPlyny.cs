namespace APBD_cw2;

public class KontenerNaPlyny : Kontener, IHazardNotifier
{
    private bool? niebezpiecznyLadunek { get; set; }
    protected static new int counter = 1;
    protected static new char Type = 'L';
    // protected double masa { get; set; } = 0;
    public KontenerNaPlyny(bool niebezpiecznyLadunek,double masaWlasna, double wysokoscWlasna, double maksymalnaLadownosc,double glebokosc) 
        : base(masaWlasna, wysokoscWlasna, maksymalnaLadownosc,glebokosc)
    {
        this.niebezpiecznyLadunek=niebezpiecznyLadunek;
        masa = 0;
        numerSeryjny = "KON-" + Type +'-'+ counter;
        counter++;
    }
    public KontenerNaPlyny(double masaWlasna, double wysokoscWlasna, double maksymalnaLadownosc,double glebokosc) : base(glebokosc,masaWlasna, wysokoscWlasna, maksymalnaLadownosc)
    {
        niebezpiecznyLadunek = null;
        masa = 0;
        numerSeryjny = $"KON-{Type}-{counter}";
        counter++;
    }

    public void DangerousSituation()
    {
        Console.WriteLine($"NiebezpiecznaSytuacja {numerSeryjny}");
    }
    
    public override void Zaladowanie(double mas)
    {
        switch (niebezpiecznyLadunek)
        {
            case true:
                if (mas <= (maksymalnaLadownosc / 2) - masa)
                {
                    this.masa += mas;
                }
                else {throw new OverfillException("ZaDużeZaladowanie");}

                break;
            case false:
                if (mas <= (maksymalnaLadownosc*0.9) - masa)
                {
                    this.masa += mas;
                }
                else 
                {throw new OverfillException("ZaDużeZaladowanie2");}
                break;
            
            case null:
               DangerousSituation();
                break;
            default:
                Console.WriteLine("cosnietak");
                break;
        }
        
        
    }
}