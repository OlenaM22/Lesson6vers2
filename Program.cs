using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(MinValue(1, 2, 3, 4, 5));  
        Console.WriteLine(MinValue(10, 20, 30));     

    public static int MinValue(params int[] numbers)
    {
        return numbers.Min();
    }
}


    int result1 = MaxValue(1, 2, 3, 4, 5);

    private static int MaxValue(int v1, int v2, int v3, int v4, int v5)
    {
        throw new NotImplementedException();
    }

    int result2 = MaxValue(10, 20, 30);
    int result3 = int.MinValue(-5, -10, -15);
}


public static int MaxValue(int a, int b, int c)
{
    return Math.Max(a, Math.Max(b, c));
}
