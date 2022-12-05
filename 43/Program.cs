// Задача 43: 
// Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите знаяения первой прямой: ");
Console.Write("b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите знаяения второй прямой: ");
Console.Write("b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double IntersectionTwoLines1 (double bx, double kx)
{
    double x = -0.5;
    double y1 = kx * x + bx ; 
    return (y1);
}

double IntersectionTwoLines2 (double by, double ky)
{
    double x = -0.5; 
    double y2 = ky * x + by;
    return (y2);
}

double intTwoLin1 = IntersectionTwoLines1(b1, k1);
double intTwoLin2 = IntersectionTwoLines2(b2, k2);
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({intTwoLin1}; {intTwoLin2})");