namespace ConsoleApp2.Models;

public class Liquid : ContainerBase, IHazardNotifier
{
    private string ladunek;
    private bool safe;

    public Liquid( double height, double kontweight, double depth, double maxCapacity, string ladunek, bool safe) : 
        base("Liquid",  height, kontweight, depth, maxCapacity)
    {
        this.id = "KON-L-" + Id++;
        this.ladunek = ladunek;
        this.safe = safe;
    }

    public void load(double weight)
    {
        if (!safe && weight > 0.5 * maxCapacity)
        {
            notify();
            throw new OverfilException();
        }
        if (weight > 0.9 * maxCapacity)
        {
            notify();
            throw new OverfilException();
        }
        
        this.weight = weight;
    }
    public void notify()
    {
        Console.WriteLine("Zauwazona proba wykonania niebiezpiecznej operacji("+id+")");
    }

    public override string ToString()
    {
        return base.ToString()+$"\nLadunek: {ladunek}";
    }
}