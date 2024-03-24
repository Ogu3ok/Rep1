namespace ConsoleApp2.Models;

public class Liquid : ContainerBase, IHazardNotifier
{
    private string ladunek;
    private bool safe;

    public Liquid(string type, double weight, double height, double kontweight, double depth, double maxCapacity, string ladunek, bool safe) : 
        base(type, weight, height, kontweight, depth, maxCapacity)
    {
        this.id = "KON-L-" + Id++;
        this.ladunek = ladunek;
        this.safe = safe;
    }

    public void load(double weight)
    {
        if (safe && weight > 0.9 * maxCapacity)
        {
            throw new OverfilException();
        }
        if (weight > 0.5 * maxCapacity)
        {
            throw new OverfilException();
        }
        this.weight += weight;
    }
    public void notify(string message)
    {
        Console.WriteLine("Zauwazona proba wykonania niebiezpiecznej operacji("+id+")");
    }

    public override string ToString()
    {
        return base.ToString()+$"Ladunek: {ladunek}";
    }
}