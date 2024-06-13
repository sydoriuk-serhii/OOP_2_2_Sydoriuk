using OOP_2_2_SS.lab_3;

public class OneDimensionalArray : ArraySumMinMax
{
    private int[] _array;

    public OneDimensionalArray()
    {
        _array = new int[0];
    }

    public void AddElement(int element)
    {
        int[] newArray = new int[_array.Length + 1];

        Array.Copy(_array, newArray, _array.Length);

        newArray[_array.Length] = element;

        _array = newArray;
    }
    public int LastElement()
    {
        if (_array.Length == 0)
        {
            Console.WriteLine("Масив пустий.");
            return 1;
        }
        else
        {
            return _array[_array.Length - 1];
        }
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