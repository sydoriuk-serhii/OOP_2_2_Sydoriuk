public class Program_3
{
    public Program_3()
    {
        int[] oneDimensionalArray = { 1, 2, 3, 4, 5 };
        OneDimensionalArray oneDimensional = new OneDimensionalArray(oneDimensionalArray);

        int sumOneDimensional = oneDimensional.Sum();
        int maxOneDimensional = oneDimensional.Max();
        int minOneDimensional = oneDimensional.Min();
    
    
        Console.WriteLine("Sum of one-dimensional array: " + sumOneDimensional);
        Console.WriteLine("Max of one-dimensional array: " + maxOneDimensional);
        Console.WriteLine("Min of one-dimensional array: " + minOneDimensional);

        int[,] twoDimensionalArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        TwoDimensionalArray twoDimensional = new TwoDimensionalArray(twoDimensionalArray);

        int sumTwoDimensional = twoDimensional.Sum();
        int maxTwoDimensional = twoDimensional.Max();
        int minTwoDimensional = twoDimensional.Min();

        Console.WriteLine("Sum of two-dimensional array: " + sumTwoDimensional);
        Console.WriteLine("Max of two-dimensional array: " + maxTwoDimensional);
        Console.WriteLine("Min of two-dimensional array: " + minTwoDimensional);

    }
}