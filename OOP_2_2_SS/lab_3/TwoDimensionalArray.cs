using OOP_2_2_SS.lab_3;


public class TwoDimensionalArray
{
    private int[,] array;
    private int rows;
    private int[] cols;

    public TwoDimensionalArray()
    {
        array = new int[0, 0];
        rows = 0;
        cols = new int[0];
    }


    public void AddRow()
    {
        int[,] newArray = new int[rows + 1, (cols.Length > 0) ? cols[0] : 0];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols[i]; j++)
            {
                newArray[i, j] = array[i, j];
            }
        }

        array = newArray;

        Array.Resize(ref cols, rows + 1);
        cols[rows] = (cols.Length > 1) ? cols[0] : 0;
        rows++;
    }

    public void AddElement(int row, int col, int element)
    {
        if (row >= rows)
        {
            Console.WriteLine("Рядок не існує.");
            return;
        }

        if (col >= cols[row])
        {
            int[,] newArray = new int[rows, Math.Max(col + 1, cols[row])];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols[i]; j++)
                {
                    newArray[i, j] = array[i, j];
                }
            }

            array = newArray;
            cols[row] = col + 1;
        }

        array[row, col] = element;
    }

    public void PrintArray()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols[i]; j++)
            {
                Console.Write(array[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
    public int Sum()
    {
        int sum = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols[i]; j++)
            {
                sum += array[i, j];
            }
        }
        return sum;
    }

    public int Max()
    {
        if (rows == 0) return int.MinValue;

        int max = array[0, 0];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols[i]; j++)
            {
                if (array[i, j] > max)
                {
                    max = array[i, j];
                }
            }
        }
        return max;
    }

    public int Min()
    {
        if (rows == 0) return int.MaxValue;

        int min = array[0, 0];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols[i]; j++)
            {
                if (array[i, j] < min)
                {
                    min = array[i, j];
                }
            }
        }
        return min;
    }
}