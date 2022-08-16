int ReadWeekDayNumber(){
    Console.Write("Введите номер дня недели: ");
    int dayNumber = Convert.ToInt32(Console.ReadLine());
    if ((dayNumber < 1) || (dayNumber > 7)){
        Console.WriteLine("Дня недели с таким номером не существует");
        return ReadWeekDayNumber();
    }
    else {
        return dayNumber;
    }
}

void IsItWeekend(int dayNumber){
    if ((dayNumber == 6) || (dayNumber == 7)){
        Console.WriteLine("Ура!!! Это выходной!!!");
    }
    else{
        Console.WriteLine("Это не выходной :(");
    }
}

int dayNumber = ReadWeekDayNumber();
IsItWeekend(dayNumber);
