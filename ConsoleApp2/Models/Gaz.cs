namespace ConsoleApp2.Models;

public class Gaz : ContainerBase, IHazardNotifier
{
    private double cisnienie;

    public Gaz(string type, double weight, double height, double kontweight, double depth, double maxCapacity, double cisnienie) :
        base(type, weight, height, kontweight, depth, maxCapacity)
    {
        this.cisnienie = cisnienie;
        this.id = "KON-G-" + Id++;
    }

    public double unload()
    {
        double capacity;
        capacity = (weight * 0.95) - kontweight;
        weight = kontweight + (0.05 * weight);
        return capacity;
    }

    public void notify(string message)
    {
        Console.WriteLine("Niebiezpiczne warunki(" + id + ")");
    }

    public override string ToString()
    {
        return base.ToString()+$"\nCisnienie: {cisnienie}";
    }
}