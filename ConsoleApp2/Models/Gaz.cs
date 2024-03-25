namespace ConsoleApp2.Models;

public class Gaz : ContainerBase, IHazardNotifier
{
    private double cisnienie;

    public Gaz(double height, double kontweight, double depth, double maxCapacity, double cisnienie) :
        base("Gaz", height, kontweight, depth, maxCapacity)
    {
        this.cisnienie = cisnienie;
        this.id = "KON-G-" + Id++;
    }

    public double unload()
    {
        double capacity;
        capacity = weight * 0.95;
        weight = 0.05 * weight;
        return capacity;
    }

    public void notify()
    {
        Console.WriteLine("Niebiezpiczne warunki(" + id + ")");
    }

    public override string ToString()
    {
        return base.ToString() + $"\nCisnienie: {cisnienie}";
    }
}