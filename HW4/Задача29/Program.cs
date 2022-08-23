void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

// Нашёл такой способ ввести числа в строку, но не до конца понятно как он работает
// int[] ints = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries).Select(i=>int.Parse(i)).ToArray<int>();



int[] GetArray()
{
    Console.WriteLine("Введите 8 чисел в строку через пробел");
    string str = Console.ReadLine();
    if (str.Split(' ').Length - 1 == 7)
    {
        int[] numbers = new int[8];
        int k = 0;
        for (int i = 0; i < 8; i++)
        {
            string num = String.Empty;
            while ((k < str.Length) && (str[k] != ' '))
            {
                num += str[k];
                k++;
            }
            k++;
            bool isNum = int.TryParse(num, out int result);
            if (isNum){
                numbers[i] = result;
            }
            else{
                Console.WriteLine("Некорректный ввод!");
                return new int[] {};
            }
        }
        return numbers;
    }
    else
    {
        return GetArray();
    }
}


PrintArray(GetArray());