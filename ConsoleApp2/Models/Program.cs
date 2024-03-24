namespace ConsoleApp2.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Kontenerowca k1 = new Kontenerowca(120, 20, 30000);
        Kontenerowca k2 = new Kontenerowca(100, 5, 10000);
        Liquid c1 = new Liquid(20, 1000, 15, 1500, "Water", true);
        Liquid c2 = new Liquid(20, 1000, 15, 1500, "Oil", false);
        Gaz g1 = new Gaz(20, 1000, 15, 1500, 1000);
        Fridge f1 = new Fridge(20, 1000, 15, 1500, "Banana", 13, 13.3);
        c1.load(1000);
        c2.load(500);
        g1.load(1000);
        f1.load(1400);
        Console.WriteLine(c1);
        k1.addCont(c1);
        k1.addCont(c2);
        k1.addCont(g1);
        k2.addCont(f1);
        Console.WriteLine(k1);
        k1.removeCont(c1);
        k2.addCont(c1);
        Console.WriteLine(k2);
        k2.moveKont(1, k1);
        Console.WriteLine(k1);
        g1.unload();
        Console.WriteLine(k1);
    }
}