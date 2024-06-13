public class Program_3
{
    public Program_3()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        start:
        Console.WriteLine("Оберіть одномірний чи двовимірний масив:");
        int choise = 0;
        choise = ReadInteger();
        switch (choise)
        { 
            case 1:
                Console.WriteLine("Введіть значення в одномірний масив:");
                OneDimensionalArray oneDimensional = new OneDimensionalArray();
                while (true)
                {
                    oneDimensional.AddElement(ReadInteger());
                    if (oneDimensional.LastElement() == 0)
                    {
                        Console.WriteLine("Закінчити введення?");
                        bool end = ReadBool();
                        if (end)
                        {
                            int sumOneDimensional = oneDimensional.Sum();
                            int maxOneDimensional = oneDimensional.Max();
                            int minOneDimensional = oneDimensional.Min();
                            Console.WriteLine("Сума одновимірного масиву: " + sumOneDimensional);
                            Console.WriteLine("Максимальне значення в одновимірному масиві: " + maxOneDimensional);
                            Console.WriteLine("Мінімальне значення в одновимірному масиві: " + minOneDimensional);
                            break;
                        }
                    }
                }
                goto start;
            case 2:
                while (true)
                {
                    TwoDimensionalArray twoDimensional = new TwoDimensionalArray();
                    while (true)
                    {
                        Console.WriteLine("1. Додати рядок");
                        Console.WriteLine("2. Додати елемент");
                        Console.WriteLine("3. Показати масив");
                        Console.WriteLine("4. Показати результати");
                        Console.WriteLine("5. Вийти");
                        Console.Write("Виберіть опцію: ");
                        int option = ReadInteger();
                        switch (option)
                        {
                            case 1:
                                twoDimensional.AddRow();
                                Console.WriteLine("Рядок додано.");
                                break;
                            case 2:
                                Console.Write("Введіть індекс рядка: ");
                                int row = ReadInteger();
                                Console.Write("Введіть індекс стовпця: ");
                                int col = ReadInteger();
                                Console.Write("Введіть елемент: ");
                                int element = ReadInteger();
                                twoDimensional.AddElement(row, col, element);
                                Console.WriteLine("Елемент додано.");
                                break;
                            case 3:
                                Console.WriteLine("Масив:");
                                twoDimensional.PrintArray();
                                break;
                            case 4:
                                int sumTwoDimensional = twoDimensional.Sum();
                                int maxTwoDimensional = twoDimensional.Max();
                                int minTwoDimensional = twoDimensional.Min();
                                Console.WriteLine("Сума двовимірного масиву: : " + sumTwoDimensional);
                                Console.WriteLine("Максимальне значення в двовимірному масиві: " + maxTwoDimensional);
                                Console.WriteLine("Мінімальне значення в двовимірному масиві: " + minTwoDimensional);
                                break;
                            case 5:
                                return;
                            default:
                                Console.WriteLine("Невідома опція, спробуйте ще раз.");
                                break;
                        }
                    }
                }
        }
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

    static bool ReadBool()
    {
        bool x;
        while (!bool.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("Невiрний формат boolean. Введiть bool: ");
        }

        return x;
    }
}
    