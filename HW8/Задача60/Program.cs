int[,,] Fill3DArray(int length, int width, int heigth)
{
    int[,,] array = new int[length, width, heigth];
    Random random = new Random();
    int[] numbers = new int[length * width * heigth];
    int m = 0;
    int elem;
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < width; j++)
        {
            for (int k = 0; k < heigth; k++)
            {
                elem = random.Next(10, 100);
                if (numbers.Contains(elem))
                {
                    k--;
                    continue;
                }
                else
                {
                    numbers[m] = elem;
                    array[i, j, k] = elem;
                    m++;
                }
            }
        }
    }
    return array;
}


void Print3DArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i,j,k]}({i},{j},{k}) ");
            }
            System.Console.WriteLine();
        }
    }
}


Random random = new Random();
Print3DArray(Fill3DArray(random.Next(2,4),random.Next(2,4),random.Next(2,4)));