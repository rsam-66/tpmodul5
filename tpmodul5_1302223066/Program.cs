internal class Program
{
    private static void Main(string[] args)
    {
        HaloGeneric.SapaUser<string>("Reimark Samuel");

        
    }
}

class HaloGeneric
{
    public static void SapaUser<T>(T X)
    {
        Console.WriteLine($"Halo user {X}", X);
    }
}

