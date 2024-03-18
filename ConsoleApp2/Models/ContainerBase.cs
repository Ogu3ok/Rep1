namespace ConsoleApp2.Models;

public abstract class ContainerBase
{
    public string id { get; set; }
    public static int Id = 0;
    public string type;
    public int weight;
    public int height;
    public int kontweight;
    public int depth;
    public int maxCapacity;
    
    public int unload()
    {
        int capacity;
        capacity = weight - kontweight;
        weight = kontweight;
        return capacity;
    }

    public void load(int weight)
    {
        this.weight += weight;
        if (weight > maxCapacity)
        {
            throw new OverfilException();
        }
    }
}