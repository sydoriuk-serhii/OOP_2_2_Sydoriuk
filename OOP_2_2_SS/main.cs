class Program
{
    public static void Main(string[] args)
    {
        start:
        int choise = 0;
        choise = Convert.ToInt32(Console.ReadLine());
        switch (choise)
        {
            case 1:
               Program_1 lab_1 = new Program_1();
                goto start;
            case 2:
                Program_2 lab_2 = new Program_2();
                goto start;
            case 3:
                Program_3 lab_3 = new Program_3();
                goto start;
            case 4:
               // Lab_4_TSMatrix lab_4 = new Lab_4_TSMatrix('a');
                goto start;
        }
    }
}