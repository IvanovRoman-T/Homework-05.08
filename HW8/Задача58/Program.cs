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


int[,] MultiplyMaricies(int[,] matrix1, int[,] matrix2)
{
    int[,] result;
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        result = new int[0, 0];
    }
    else
    {
        result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
        int s;
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                s = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    s += matrix1[i, k] * matrix2[k, j];
                }
                result[i, j] = s;
            }
        }
    }
    return result;
}


Random rand = new Random();
int[,] matr1 = Fill2DArray(rand.Next(2, 4), rand.Next(2, 4));
int[,] matr2 = Fill2DArray(rand.Next(2, 4), rand.Next(2, 4));
Print2DArray(matr1);
System.Console.WriteLine();
Print2DArray(matr2);
System.Console.WriteLine();
int[,] result = MultiplyMaricies(matr1, matr2);
if (result.GetLength(0) == 0)
{
    System.Console.WriteLine("Такие матрицы перемножить нельзя");
}
else
{
    System.Console.WriteLine("Результат:");
    Print2DArray(result);
}