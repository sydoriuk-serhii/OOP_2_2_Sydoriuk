using OOP_2_2_SS.lab_3;

public class OneDimensionalArray : ArraySumMinMax
{
    private readonly int[] _array;

    public OneDimensionalArray(int[] array)
    {
        _array = array;
    }

    public int Sum()
    {
        int sum = 0;
        foreach (int element in _array)
        {
            sum += element;
        }
        return sum;
    }

    public int Max()
    {
        int max = int.MinValue;
        foreach (int element in _array)
        {
            if (element > max)
            {
                max = element;
            }
        }
        return max;
    }

    public int Min()
    {
        int min = int.MaxValue;
        foreach (int element in _array)
        {
            if (element < min)
            {
                min = element;
            }
        }
        return min;
    }
}