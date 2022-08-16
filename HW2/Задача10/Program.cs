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


void ShowSecondDigit(int number){
    int secondDigit = (number%100) / 10;
    Console.WriteLine($"Вторая цифра числа {number} - {secondDigit}");
}

int number = ReadNumber();
ShowSecondDigit(number);