namespace ConsoleApp2.Models;

public abstract class ContainerBase
{
    protected string id { get; set; }
    protected static int Id = 0;
    protected string type;
    protected double weight;
    protected double height;
    protected double kontweight;
    protected double depth;
    protected double maxCapacity;

    protected ContainerBase(string type, double weight, double height, double kontweight, double depth, double maxCapacity)
    {
        this.type = type;
        this.weight = weight;
        this.height = height;
        this.kontweight = kontweight;
        this.depth = depth;
        this.maxCapacity = maxCapacity;
        this.id = id;
    }

    public double unload()
    {
        double capacity;
        capacity = weight - kontweight;
        weight = kontweight;
        return capacity;
    }

    public void load(double weight)
    {
        if (weight > maxCapacity)
        {
            throw new OverfilException();
        }
        this.weight += weight;
    }

    public override string ToString()
    {
        return $"Kontainer: {id}. Current weight: {weight}\nParams[H:{height}, W:{kontweight}, D:{depth}, C{maxCapacity}]";
    }
}