int ReadNumber(){
    Console.Write("Введите натуральное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 1){
        Console.WriteLine("Это не натуральное число");
        return ReadNumber();
    }
    else {
    return number;
    }
}

int[] FindCubes(int number){
    int[] array = new int[number];
    for (int i = 1; i <= number; i++){
        array [i-1] = Convert.ToInt32(Math.Pow(i, 3));
    }
    return array;
}

void PrintArray(int[] array){
    string str = String.Empty;
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}

int number = ReadNumber();
PrintArray(FindCubes(number));