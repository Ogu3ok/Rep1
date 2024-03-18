namespace ConsoleApp2.Models;

public class Liquid : ContainerBase, IHazardNotifier
{
    private string ladunek;
    private bool safe;
    public Liquid(int weight, int height, int kontweight, int depth, int maxCapacity)
    {
        id = "KON-L-" + ContainerBase.Id++;
        this.weight = weight;
        this.height = height;
        this.kontweight = kontweight;
        this.depth = depth;
        this.maxCapacity = maxCapacity;
    }
}