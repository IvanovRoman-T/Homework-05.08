string FindIntersectionPoint(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            return "Прямые совпадают.";
        }
        else
        {
            return "Прямые параллельны.";
        }
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        return $"Прямые пересекаются в точке ({x}; {y})";
    }
}

System.Console.WriteLine("Прямые задаются уравнениями: y = k1 * x + b1, y = k2 * x + b2");
System.Console.Write("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine(FindIntersectionPoint(k1,b1,k2,b2));