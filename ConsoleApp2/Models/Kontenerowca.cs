namespace ConsoleApp2.Models;

public class Kontenerowca
{
    private List<ContainerBase> conteners;
    private int maxPrzedkosc;
    private int maxNKont;
    private double maxWeight;

    public Kontenerowca(int maxPrzedkosc, int maxNKont, double maxWeight)
    {
        this.maxPrzedkosc = maxPrzedkosc;
        this.maxNKont = maxNKont;
        this.maxWeight = maxWeight;
    }

    public void addCont(ContainerBase container)
    {
        conteners.Add(container);
    }

    public void removeCont(ContainerBase container)
    {
        conteners.Remove(container);
    }

    public void replaceCont(int idx, ContainerBase c2)
    {
        conteners.RemoveAt(idx);
        conteners.Insert(idx, c2);
    }

    public void moveKont(int idx, Kontenerowca target)
    {
        ContainerBase cont = conteners[idx];
        target.addCont(cont);
        conteners.Remove(cont);
    }

    public override string ToString()
    {
        String text = $"Kontenerowca[Maksymalna przedkosc: {maxPrzedkosc}\nMaksymalna licba prewozonych kontenerow: {maxNKont}\nDopuszcalna masa: {maxWeight}]\n";
        foreach (var container in conteners)
        {
            text += container.ToString();
        }
        return text;
    }
}