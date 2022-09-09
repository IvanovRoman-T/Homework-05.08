int GetNumberM()
{
    Console.Write("Введите натуральное число M: ");
    if (!(int.TryParse(Console.ReadLine(), out int number)) || (number < 0))
    {
        return GetNumberM();
    }
    else
    {
        return number;
    }
}


int GetNumberN(int M)
{
    Console.Write("Введите натуральное число N: ");
    if (!(int.TryParse(Console.ReadLine(), out int number)) || (number < 0))
    {
        return GetNumberN(M);
    }
    else
    {
        return number;
    }
}


int CalculateAckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (n == 0)
        {
            return CalculateAckermannFunction(m - 1, 1);
        }
        else
        {
            return CalculateAckermannFunction(m - 1, CalculateAckermannFunction(m, n - 1));
        }
    }
}


int numberM = GetNumberM();
int numberN = GetNumberN(numberM);
System.Console.WriteLine(CalculateAckermannFunction(numberM, numberN));