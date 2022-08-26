Random random = new Random();
int[] numbers = new int[random.Next(1, 11)];


int[] FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(100, 1000);
    }
    return arr;
}


int CountEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}

int[] array = FillArray(numbers);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine(CountEvenNumbers(array));
