class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        Console.WriteLine(GetAverage(new []{1,2,4,6,6}));
    }

    public static int GetAverage(int[] arr)
    {
        var x = 0;
        foreach (var b in arr)
        {
            x += b;
        }
    
        return x / arr.Length;
    }

    public static int Max(int[] arr)
    {
        var x = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (x < arr[i])
                x = arr[i];
        }

        return x;
    }
}