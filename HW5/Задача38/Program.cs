Random random = new Random();
int[] numbers = new int[random.Next(2, 11)];


int[] FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(-100, 101);
    }
    return arr;
}


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}


int FindDiffBetweenMaxAndMin(int[] arr)
{
    int min = arr[0];
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
        else
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
    }
    return max - min;
}


int[] array = FillArray(numbers);
PrintArray(array);
System.Console.WriteLine();
System.Console.Write(FindDiffBetweenMaxAndMin(array));