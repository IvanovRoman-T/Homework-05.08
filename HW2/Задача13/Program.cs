char ShowThirdDidit(string number){
    if (number.Length < 3){
        return 'a'; 
    }
    else{
        return number[2];
    }
}


Console.Write("Введите целое число: ");
string number = Console.ReadLine();
if (ShowThirdDidit(number) == 'a'){
    Console.WriteLine("Третьей цифры нет");
}
else {
    Console.WriteLine($"Третья цифра числа {number} - {ShowThirdDidit(number)}");
}