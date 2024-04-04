using OOP_2_2_SS.lab_3;
public class TwoDimensionalArray : ArraySumMinMax
{
    private readonly int[,] _array;

    public TwoDimensionalArray(int[,] array)
    {
        _array = array;
    }

    public int Sum()
    {
        int sum = 0;
        for (int i = 0; i < _array.GetLength(0); i++)
        {
            for (int j = 0; j < _array.GetLength(1); j++)
            {
                sum += _array[i, j];
            }
        }
        return sum;
    }

    public int Max()
    {
        int max = int.MinValue;
        for (int i = 0; i < _array.GetLength(0); i++)
        {
            for (int j = 0; j < _array.GetLength(1); j++)
            {
                if (_array[i, j] > max)
                {
                    max = _array[i, j];
                }
            }
        }
        return max;
    }

    public int Min()
    {
        int min = int.MaxValue;
        for (int i = 0; i < _array.GetLength(0); i++)
        {
            for (int j = 0; j < _array.GetLength(1); j++)
            {
                if (_array[i, j] < min)
                {
                    min = _array[i, j];
                }
            }
        }
        return min;
    }
}