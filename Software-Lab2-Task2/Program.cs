class Program
{
    static void Main(string[] args)
    {
#if DEBUG
        Matrix a = new();
        Matrix b = new(5);
        Matrix c = new(5, 3);
#else
        Console.WriteLine("\t\"Матрица MxN\"");
        Console.Write("\nВведите число строк матрицы: ");
        int m = Convert.ToInt32(Console.ReadLine());
        while (m <= 0)
        {
            Console.Write("(!) Число должно быть положительным. Попробуйте снова: ");
            m = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("\nВведите число столбцов матрицы: ");
        int n = Convert.ToInt32(Console.ReadLine());
        while (n <= 0)
        {
        Console.Write("(!) Число должно быть положительным. Попробуйте снова: ");
        n = Convert.ToInt32(Console.ReadLine());
        }   
        Matrix matrix = new(m, n);
#endif
#if DEBUG
        a.FillRandom();
        b.FillRandom(1, 10);
        c.FillRandom(-10, 10);
#else
        Console.WriteLine("\nНебходимо ввести диапазон чисел для элементов массива");
        Console.Write("\nВведите число начала диапазона: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nВведите число конца диапазона: ");
        int b = Convert.ToInt32(Console.ReadLine());
        while (b <= a)
        {
            Console.Write("(!) Число конца диапазона должно быть больше его начала. Попробуйте снова: ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        matrix.FillRandom(a, b);
#endif
#if DEBUG
        a.Info();
        b.Info();
        c.Info();
        Console.WriteLine("\nПрограмма завершена (режим DEBUG)");
#else
        int choice;
        do
        {
            Console.Clear();
            Console.WriteLine("\n=============== Меню действий ===============" +
                "\n1. Вывод матрицы" +
                "\n2. Нахождение максимального элемента матрицы" +
                "\n3. Нахождение минимального элемента матрицы" +
                "\n4. Вывод всей информации" +
                "\n5. Выход из программы");
            Console.Write("\nВыберите действие: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: matrix.Print(); break;
                case 2: matrix.Max(); break;
                case 3: matrix.Min(); break;
                case 4: matrix.Info(); break;
                case 5:
                    break;
                default:
                    Console.WriteLine("(!) Неверный выбор. Попробуйте снова");
                    break;
            }
            if (choice != 5)
            {
                Console.Write("\nНажмите любую клавишу, чтобы продолжить...");
                Console.ReadKey();
            }
        }
        while (choice != 5);
        Console.WriteLine("\nПрограмма завершена (режим RELEASE)");
#endif
    }
}