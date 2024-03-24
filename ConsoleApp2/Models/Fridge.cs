namespace ConsoleApp2.Models;

public class Fridge : ContainerBase
{
    private string product;
    private double temp;
    private double wymTemp;

    public Fridge(string type, double weight, double height, double kontweight, double depth, double maxCapacity, string product, double temp, double wymTemp) : 
        base(type, weight, height, kontweight, depth, maxCapacity)
    {
        this.id = "KON-G-" + Id++;
        this.product = product;
        this.temp = temp;
        this.wymTemp = wymTemp;
    }

    public override string ToString()
    {
        return base.ToString()+$"\nProduct: {product}, temp: {temp}";
    }
}