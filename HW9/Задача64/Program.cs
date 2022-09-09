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


void ShowNumbersFromMToN(int M, int N, int k = 1)
{
    if (k < M)
    {
        k = M;
    }
    if (k < N)
    {
        System.Console.Write($"{k}, ");
        ShowNumbersFromMToN(M, N, k + 1);
    }
    else
    {
        System.Console.Write(k);
    }
}


int numberM = GetNumberM();
int numberN = GetNumberN(numberM);
ShowNumbersFromMToN(numberM, numberN);