class Matrix
{
    int m, n;
    int[,] matrix;
    public Matrix(int m, int n)
    {
        this.m = m;
        this.n = n;
        matrix = new int[m, n];
    }
    public Matrix(int size) : this(size, size) { }
    public Matrix() : this(2, 2) { }
    public void FillRandom() => FillRandom(0, 100);
    public void FillRandom(int min, int max)
    {
        Random random = new Random();
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                matrix[i, j] = random.Next(min, max + 1);
    }
    public void Print()
    {
        Console.WriteLine("\n");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++) Console.Write($"{matrix[i, j],4}");
            Console.WriteLine();
        }
    }
    public void Max()
    {
        int max = matrix[0, 0];
        foreach (var item in matrix)
            if (item > max) max = item;
        Console.WriteLine($"\nМаксимальный элемент матрицы: {max}");
    }
    public void Min()
    {
        int min = matrix[0, 0];
        foreach (var item in matrix)
            if (item < min) min = item;
        Console.WriteLine($"\nМинимальный элемент матрицы: {min}");
    }
    public void Info()
    {
        Console.WriteLine($"\nМатрица {m}x{n}:");
        Print();
        Max();
        Min();
    }
}