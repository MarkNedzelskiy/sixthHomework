/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double[] InputValues()
{
    double[] array = new double[4];
    
    Console.WriteLine("Введите значение b1: ");
    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out array[0])) break;
        else Console.WriteLine("Введите число!");
    }

    Console.WriteLine("Введите значение к1: ");
    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out array[1])) break;
        else Console.WriteLine("Введите число!");
    }

    Console.WriteLine("Введите значение b2: ");
    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out array[2])) break;
        else Console.WriteLine("Введите число!");
    }

    Console.WriteLine("Введите значение к2: ");
    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out array[3])) break;
        else Console.WriteLine("Введите число!");
    }

    return array;
}

double FindIntersectionPoint (double[] values)
{
    double point = (values[2] - values[0])/(values[1] - values[3]);
    return point;
}

double[] values = InputValues();
double intersectionPoint = FindIntersectionPoint(values);
Console.WriteLine(intersectionPoint);