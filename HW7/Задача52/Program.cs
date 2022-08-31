int[,] Fill2DArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(-10, 10);
        }
    }
    return array;
}

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(String.Format("{0, 4}", arr[i, j]));
        }
        System.Console.WriteLine();
    }
}

string FindAverageOfColumns(int[,] arr)
{
    string result = "";
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        result += $"{sum / Convert.ToDouble(arr.GetLength(0))}; ";
    }
    return result;
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

int[,] numbers = Fill2DArray(m, n);
Print2DArray(numbers);
System.Console.WriteLine(FindAverageOfColumns(numbers));