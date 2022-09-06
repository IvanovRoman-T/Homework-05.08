int[,] Fill2DArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0, 11);
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
            Console.Write(String.Format("{0, 3}", arr[i, j]));
        }
        System.Console.WriteLine();
    }
}


int FindRowWithLeastSum(int[,] arr)
{
    int minsum = 0;
    int number = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if (i == 0)
        {
            minsum = sum;
        }
        else
        {
            if (minsum > sum)
            {
                minsum = sum;
                number = i;
            }
        }
    }
    return number + 1;
}


Random rand = new Random();
int[,] array = Fill2DArray(rand.Next(2, 11), rand.Next(2, 11));
Print2DArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {FindRowWithLeastSum(array)}");