double[,] Fill2DArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(random.NextDouble() * random.Next(-100, 101), 3);
        }
    }
    return array;
}

void Print2DArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(String.Format("{0, 8}", arr[i, j]));
        }
        System.Console.WriteLine();
    }
}


System.Console.Write("Введите число строк: ");
bool FirstIsNumber = int.TryParse(Console.ReadLine(), out int m);

if (!FirstIsNumber)
{
    System.Console.WriteLine("Некорректный ввод");
    return;
}

System.Console.Write("Введите число столбцов: ");
bool SecondIsNumber = int.TryParse(Console.ReadLine(), out int n);

if (!SecondIsNumber)
{
    System.Console.WriteLine("Некорректный ввод");
    return;
}

double[,] result = Fill2DArray(m, n);
Print2DArray(result);