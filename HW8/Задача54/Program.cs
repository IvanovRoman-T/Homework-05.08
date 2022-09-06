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
            Console.Write(String.Format("{0, 3}", arr[i, j]));
        }
        System.Console.WriteLine();
    }
}


int[,] Sort2DArray(int[,] arr)
{
    for (int k = 0; k < arr.GetLength(0); k++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int i = 0; i < arr.GetLength(1) - 1; i++)
            {
                if (arr[k, i] < arr[k, i + 1])
                {
                    int c = arr[k, i];
                    arr[k, i] = arr[k, i + 1];
                    arr[k, i + 1] = c;
                }
            }
        }
    }
    return arr;
}

Random rand = new Random();
int[,] array = Fill2DArray(rand.Next(2,11), rand.Next(2,11));
Print2DArray(array);
System.Console.WriteLine();
int[,] result = Sort2DArray(array);
Print2DArray(result);