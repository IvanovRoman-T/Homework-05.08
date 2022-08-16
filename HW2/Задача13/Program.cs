void ShowThirdDidit(string number){
    if (number.Length < 3){
        Console.WriteLine("Третьей цифры нет");
    }
    else{
        Console.WriteLine($"Третья цифра числа {number} - {number[2]}");
    }
}


Console.Write("Введите целое число: ");
string number = Console.ReadLine();
ShowThirdDidit(number);