/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

using static System.Console;
Clear();

Write("Введите размер массива: ");
int length = int.Parse(ReadLine()!);

Write("Введите min значение массива: ");
int min = int.Parse(ReadLine()!);

Write("Введите max значение массива: ");
int max = int.Parse(ReadLine()!);

double[] array = GetArray(length, min, max);
WriteLine($"[{String.Join(" ", array)}]");

double maxValue = FindMax(array);
double minValue = FindMin(array);
double difference = maxValue - minValue;
WriteLine($"Разница между max и min значением в массиве равна: {difference:f2}");

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] result = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1) + Math.Round(rnd.NextDouble(), 2);
    }
    return result;
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            double temp = max;
            max = array[i];
            array[i] = max;
        }
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            double temp = min;
            min = array[i];
            array[i] = min;
        }
    }
    return min;
}