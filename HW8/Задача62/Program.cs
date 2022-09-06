int[,] Fill2DArray(int n)
{
    int[,] array = new int[n, n];
    int direction = 0;
    int i = 0;
    int j = 0;
    for (int k = 1; k < n * n + 1; k++)
    {
        if (direction == 0)
        {
            array[i, j] = k;
            if ((j + 1 > n - 1) || (array[i, j + 1] != 0))
            {
                direction++;
                j--;
                i++;
            }
            j++;
        }
        else
        {
            if (direction == 1)
            {
                array[i, j] = k;
                if ((i + 1 > n - 1) || (array[i + 1, j] != 0))
                {
                    direction++;
                    i--;
                    j--;
                }
                i++;
            }
            else
            {
                if (direction == 2)
                {
                    array[i, j] = k;
                    if ((j - 1 < 0) || (array[i, j - 1] != 0))
                    {
                        direction++;
                        j++;
                        i--;
                    }
                    j--;
                }
                else
                {
                    array[i, j] = k;
                    if ((i - 1 < 0) || (array[i - 1, j] != 0))
                    {
                        direction = 0;
                        i++;
                        j++;
                    }
                    i--;
                }
            }
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


Print2DArray(Fill2DArray(10));