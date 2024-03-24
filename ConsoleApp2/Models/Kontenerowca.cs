namespace ConsoleApp2.Models;

public class Kontenerowca
{
    private List<ContainerBase> containers;
    private int maxPrzedkosc;
    private int maxNKont;
    private double maxWeight;

    public Kontenerowca(int maxPrzedkosc, int maxNKont, double maxWeight)
    {
        this.maxPrzedkosc = maxPrzedkosc;
        this.maxNKont = maxNKont;
        this.maxWeight = maxWeight;
        containers = new List<ContainerBase>();
    }

    public void addCont(ContainerBase container)
    {
        if (containers.Count < maxNKont)
            containers.Add(container);
        else 
            throw new ArgumentException("Maximum number of containers added");
    }

    public void removeCont(ContainerBase container)
    {
        containers.Remove(container);
    }

    public void replaceCont(int idx, ContainerBase c2)
    {
        containers.RemoveAt(idx);
        containers.Insert(idx, c2);
    }

    public void moveKont(int idx, Kontenerowca target)
    {
        ContainerBase cont = containers[idx];
        target.addCont(cont);
        containers.Remove(cont);
    }

    public override string ToString()
    {
        String text = $"Kontenerowca[Maksymalna przedkosc: {maxPrzedkosc}\nMaksymalna licba prewozonych kontenerow: {maxNKont}\nDopuszcalna masa: {maxWeight}]\n";
        foreach (var container in containers)
        {
            text += container.ToString();
            text += '\n';
        }

        text += '\n';
        return text;
    }
}