namespace ConsoleApp2.Models;

public class Fridge : ContainerBase
{
    private string product;
    private double temp;
    private double wymTemp;

    public Fridge( double height, double kontweight, double depth, double maxCapacity, string product, double temp, double wymTemp) : 
        base("Fridge", height, kontweight, depth, maxCapacity)
    {
        this.id = "KON-F-" + Id++;
        this.product = product;
        this.temp = temp;
        this.wymTemp = wymTemp;
    }

    public override string ToString()
    {
        return base.ToString()+$"\nProduct: {product}, temp: {temp}";
    }
}