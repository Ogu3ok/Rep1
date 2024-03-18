namespace ConsoleApp2.Models;

public class OverfilException : Exception
{
    public OverfilException() : base("Container is overfilled!!!")
    { }
}