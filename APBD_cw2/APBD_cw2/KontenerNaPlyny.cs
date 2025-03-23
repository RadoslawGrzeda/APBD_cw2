namespace APBD_cw2;

public class KontenerNaPlyny : Kontener, IHazardNotifier
{
    private bool? niebezpiecznyLadunek { get; set; }

    protected static new int counter = 1;
    protected static new char Type = 'L';


    public KontenerNaPlyny(bool niebezpiecznyLadunek,double masaWlasna, double wysokoscWlasna, double maksymalnaLadownosc,double glebokosc) : base(glebokosc,masaWlasna, wysokoscWlasna, maksymalnaLadownosc)
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

    public void DangerousSituation(string dangerousSituation)
    {
        Console.WriteLine(dangerousSituation);
    }

    public void DangerousSituation()
    {
        throw new NotImplementedException();
    }

    public override void Dotankuj(double mas)
    {
        switch (niebezpiecznyLadunek)
        {
            case true:
                if (mas < (maksymalnaLadownosc / 2) - masa)
                {
                    masa += mas;
                }
                else throw new OverfillException("ZaDużeDoładowanie");

                break;
            case false:
                if (mas < (maksymalnaLadownosc*0.9) - masa)
                {
                    masa += mas;
                }
                else throw new OverfillException("ZaDużeDoładowanie");

                break;
            case null:
               DangerousSituation("NiebezpiecznaOperacjaNieznanyŁadunekTypPlynowKontenera");
                break;
            default:
                Console.WriteLine("cosnietak");
                break;
        }
        
        
    }
}