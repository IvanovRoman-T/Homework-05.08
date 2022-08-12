double number1 = Convert.ToDouble(Console.ReadLine());
double number2 = Convert.ToDouble(Console.ReadLine());
double number3 = Convert.ToDouble(Console.ReadLine());
double max;
if (number1 >= number2){
    max = number1;
}
else {
    max = number2;
}
if (number3 >= max){
    Console.WriteLine($"max = {number3}");
}
else {
    Console.WriteLine($"max = {max}");
}