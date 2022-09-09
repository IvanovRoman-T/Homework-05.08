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
    Console.Write("Введите натуральное число N, N > M: ");
    if (!(int.TryParse(Console.ReadLine(), out int number)) || (number < 0) || (number < M))
    {
        return GetNumberN(M);
    }
    else
    {
        return number;
    }
}


int SumNumbersFromMToN(int M, int N, int k = 1, int sum = 0)
{
    if (k < M)
    {
        k = M;
    }
    if (k <= N)
    {
        sum += k;
        return SumNumbersFromMToN(M, N, k + 1, sum);
    }
    else
    {
        return sum;
    }
}


int numberM = GetNumberM();
int numberN = GetNumberN(numberM);
System.Console.WriteLine(SumNumbersFromMToN(numberM, numberN));