Random random = new Random();
int[] numbers = new int[random.Next(1, 11)];


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


int FindSumOfOddPositions(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}


int[] array = FillArray(numbers);
PrintArray(array);
System.Console.WriteLine();
System.Console.Write(FindSumOfOddPositions(array));