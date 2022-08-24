/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Write("Введите b1: ");
float b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите k1: ");
float k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите b2: ");
float b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите k2: ");
float k2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2)
{
    if (b1 == b2)
    {
        Console.WriteLine("Линии полностью совпадают");
    }
    else
    {
        Console.WriteLine("Линии параллельны друг другу");
    }
    return;
}
float x = (b2 - b1) / (k1 - k2);

float y1 = k1 * x + b1;

Console.WriteLine($"Линии пересекаются в точке с координатами ({x}, {y1})");

