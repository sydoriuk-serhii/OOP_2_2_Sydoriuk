public class Program_2
{
    public Program_2()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть завдання:");
        int n = ReadInteger();
        switch(n) {
            case 1:
                func_1();
                break;
            case 2:
                func_2();
                break;
            case 3:
                func_3();
                break;
            case 4:
                func_4();
                break;
            case 5:
                func_5();
                break;
            case 6:
                func_6();
                break;
        }
        Program_2 nextLab = new Program_2();
    }

    public void func_1()
    {
        Console.WriteLine("1.1\n" +
                          "Введіть кількість чисел:");
        int nums = ReadInteger();

        double[] numbers = new double[nums];
        double maxNegative = double.MinValue;

        for (int i = 0; i < nums; i++)
        {
            Console.WriteLine($"Введіть {i + 1}-е число:");
            numbers[i] = ReadDouble();
            if (numbers[i] < 0 && numbers[i] > maxNegative)
            {
                maxNegative = numbers[i];
            }
        }

        if (maxNegative == double.MinValue)
        {
            Console.WriteLine("Від'ємних чисел не знайдено.");
        }
        else
        {
            Console.WriteLine($"Найбільше від'ємне число: {maxNegative}");
        }
    }

    public void func_2()
    {
        Console.WriteLine("1.2\n" +
                          "Введіть розмірність векторів:");
        int n = ReadInteger(); // Розмірність векторів
        double[] x; // Координати вектора x
        double[] y; // Координати вектора y
        double dotProduct; // Скалярний добуток векторів
        double cosAngle; // Косинус кута між векторами

        x = new double[n];
        y = new double[n];

        Console.WriteLine("Введіть координати вектора x:");
        for (int i = 0; i < n; i++)
        {
            x[i] = ReadDouble();
        }

        Console.WriteLine("Введіть координати вектора y:");
        for (int i = 0; i < n; i++)
        {
            y[i] = ReadDouble();
        }

        //Розрахунок скалярного добутку:
        dotProduct = 0;
        for (int i = 0; i < n; i++)
        {
            dotProduct += x[i] * y[i];
        }

        //Розрахунок косинуса кута:
        double xLength = 0;
        double yLength = 0;

        for (int i = 0; i < n; i++)
        {
            xLength += x[i] * x[i];
            yLength += y[i] * y[i];
        }

        cosAngle = dotProduct / (Math.Sqrt(xLength) * Math.Sqrt(yLength));
        Console.WriteLine($"Косинус кута між векторами: {cosAngle}");
    }

    public void func_3()
    {
        Console.WriteLine("1.3\n" +
                          "Введіть розмір масиву:");
        int n = ReadInteger();
        double[] array = new double[n];
        double a, b;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введіть {i + 1}-е число:");
            array[i] = ReadDouble();
        }

        Console.WriteLine("Введіть A:");
        a = ReadDouble();
        Console.WriteLine("Введіть B:");
        b = ReadDouble();

        void SqueezeArray(double[] arr, double a, double b)
        {
            int i = 0, j = 0;
            while (i < arr.Length)
            {
                if (Math.Abs(arr[i]) < a || Math.Abs(arr[i]) > b)
                {
                    arr[j++] = arr[i];
                }

                i++;
            }

            while (j < arr.Length)
            {
                arr[j++] = 0;
            }
        }

        SqueezeArray(array, a, b);
        foreach (int i in array)
        {
            Console.WriteLine(i);
        }
    }

    public void func_4()
    {
        Console.WriteLine("2.1\n" +
                          "Введіть розмір:");
        int n = ReadInteger();
        int[,] matrix = new int[n, n];
        Console.WriteLine("Введіть усі елементи матриці:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = ReadInteger();
            }
        }

        for (int i = 1; i < n; i += 2)
        {
            for (int j = 0; j < n - 1; j++)
            {
                for (int k = 0; k < n - j - 1; k++)
                {
                    if (matrix[i, k] < matrix[i, k + 1])
                    {
                        int temp = matrix[i, k];
                        matrix[i, k] = matrix[i, k + 1];
                        matrix[i, k + 1] = temp;
                    }
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }

    }

    public void func_5()
    {
        Console.WriteLine("2.2\n" +
                          "Введіть розмірність матриці:");
        int n = ReadInteger(); // Розмірність матриці
        int[,] matrix = new int[n, n];
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = random.Next(-1, 10);
            }
        }

        int sum = 0;
        for (int j = 0; j < n; j++)
        {
            bool hasNegative = false;

            for (int i = 0; i < n; i++)
            {
                if (matrix[i, j] < 0)
                {
                    hasNegative = true;
                    break;
                }
            }

            if (!hasNegative)
            {
                for (int i = 0; i < n; i++)
                {
                    sum += matrix[i, j];
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }

        Console.WriteLine("Сума: " + sum);

    }

    public void func_6()
    {
        Console.WriteLine("2.3\n" +
                          "Введіть розмірність матриці:");
        int n = ReadInteger(); // Розмірність матриці
        // Створення та заповнення матриці випадковими числами
        int[,] matrix = new int[n, n];
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = random.Next(-10, 10);
            }
        }

        // Виведення матриці
        Console.WriteLine("Матриця:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,3} ", matrix[i, j]);
            }

            Console.WriteLine();
        }

        // Знаходження мінімального модуля суми елементів побічних діагоналей
        int minSum = int.MaxValue;
        for (int k = 0; k < n; k++)
        {
            int sum = 0;
            for (int i = 0, j = k; i < n && j < n; i++, j++)
            {
                sum += Math.Abs(matrix[i, j]);
            }

            minSum = Math.Min(minSum, sum);
        }

        // Виведення результату
        Console.WriteLine("Мінімальна сума модулів елементів діагоналей: {0}", minSum);
    }

    static int ReadInteger()
    {
        int x;
        while (!int.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("Невiрний формат числа. Введiть integer: ");
        }
        return x;
    }
    static double ReadDouble()
    {
        double x;
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("Невiрний формат числа. Введiть Double: ");
        }
        return x;
    }
}