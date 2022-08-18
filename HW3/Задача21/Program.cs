double FindDistance(double[] array1, double[] array2){
    double sum = 0;
    for (int i =0; i < 3; i++){
        sum += Math.Pow(array1[i] - array2[i], 2);
    }
    return Math.Sqrt(sum);
}

double[] point1 = new double[3];
Console.WriteLine("Введите координаты первой точки:");
point1[0] = Convert.ToDouble(Console.ReadLine());
point1[1] = Convert.ToDouble(Console.ReadLine());
point1[2] = Convert.ToDouble(Console.ReadLine());
double[] point2 = new double[3];
Console.WriteLine("Введите координаты второй точки:");
point2[0] = Convert.ToDouble(Console.ReadLine());
point2[1] = Convert.ToDouble(Console.ReadLine());
point2[2] = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Расстояние между этими точками равно {FindDistance(point1, point2)}");

