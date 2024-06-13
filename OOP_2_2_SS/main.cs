using OOP_2_2_SS.Lab_4;

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
                Program_4 lab_4 = new Program_4();
                goto start;
        }
    }
}