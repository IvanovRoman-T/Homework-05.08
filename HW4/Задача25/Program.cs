int RaiseToThePower(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result *= a;
    }
    return result;
}

int GetFirstNumber()
{
    Console.Write("Введите целое число: ");
    if (!(int.TryParse(Console.ReadLine(), out int number)))
    {
        return GetFirstNumber();
    }
    else
    {
        return number;
    }
}

int GetSecondNumber()
{
    Console.Write("Введите натуральную степень: ");
    if (!(int.TryParse(Console.ReadLine(), out int number)) || (number < 0))
    {
        return GetSecondNumber();
    }
    else
    {
        return number;
    }
}

int result = RaiseToThePower(GetFirstNumber(), GetSecondNumber());
Console.WriteLine(result);
