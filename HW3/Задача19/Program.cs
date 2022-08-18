int ReadNumber(){
    Console.Write("Введите пятизначное число: ");
    string number = Console.ReadLine();
    if (number.Length != 5){
        Console.WriteLine("Это не пятизначное число");
        return ReadNumber();
    }
    else {
    return Convert.ToInt32(number);
    }
}

bool IsItPalindrome(string str){
    int len = str.Length;
    for (int i = 0; i <= len / 2; i++){
        if (str[i] != str[len - 1 - i]){
            return false;
        }        
    }
    return true;
}

int number = ReadNumber();
if (IsItPalindrome(Convert.ToString(number))){
    Console.WriteLine("Это палиндром.");
}
else{
    Console.WriteLine("Это не палиндром.");
}