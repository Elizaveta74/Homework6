/* 
Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/


Console.Write("Введите количество элементов массива: ");
string mAsString = Console.ReadLine();
if (int.TryParse(mAsString, out int M))
{
    if (M <= 0)
    {
        Console.WriteLine("Количество элементов должно быть положительным числом");
        return;
    }
}
else
{
    Console.WriteLine($"Ожидалось число, а вы ввели '{mAsString}'");
    return;
}
Console.WriteLine("Введите целые числа массива");
// Выделение памяти под массив с кол-ом элементов М
int[] array = new int[M];

int positiveNumbersCount = 0;

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент с индексом {i}: ");
    string elementAsString = Console.ReadLine();
    if (int.TryParse(elementAsString, out int elementAsNumber))
    {
        array[i] = elementAsNumber;
        if (array[i] > 0)
        {
            positiveNumbersCount++;
        }
    }
    else
    {
        Console.WriteLine($"Ожидалось число, а вы ввели '{elementAsString}'");
        return;
    }
}

string arrayAsString = string.Join(", ", array);
Console.WriteLine($"Массив = {arrayAsString}");
Console.WriteLine($"Количество положительных элементов = {positiveNumbersCount}");
