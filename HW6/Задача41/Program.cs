int[] Getnums(int count)
{
    int[] nums = new int[count];
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"Введите {i + 1} число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        nums[i] = number;
    }
    return nums;
}


int CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}


System.Console.Write("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] numbers = Getnums(m);
System.Console.WriteLine($"Количество положительных чисел равно {CountPositive(numbers)}");

