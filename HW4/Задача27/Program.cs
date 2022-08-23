int GetNumber()
{
    Console.Write("Введите целое число: ");
    if (!(int.TryParse(Console.ReadLine(), out int number)))
    {
        return GetNumber();
    }
    else
    {
        return number;
    }
}

int GetSumOfDigits(int number)
{
    int o = 0;
    if (number < 0)
    {
        o = 1;
    }
    string num = number.ToString();
    int sum = 0;
    for (int i = o; i < num.Length; i++)
    {
        sum += Convert.ToInt32(Convert.ToString(num[i]));
    }
    return sum;
}

int result = GetSumOfDigits(GetNumber());
Console.WriteLine(result);


