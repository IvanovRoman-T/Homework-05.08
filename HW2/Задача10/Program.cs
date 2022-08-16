int ReadNumber(){
    Console.Write("Введите трёхзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if ((number > 999) || (number < 100))
    {
        Console.WriteLine("Число не трёхзначное");
        return ReadNumber();
    }
    else
    {
        return number;
    }
}


int ShowSecondDigit(int number){
    return (number%100) / 10;
}

int number = ReadNumber();
Console.WriteLine($"Вторая цифра числа {number} - {ShowSecondDigit(number)}");