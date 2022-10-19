/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

using static System.Console;
Clear();

Write("Введите размер массива: ");
int length = int.Parse(ReadLine()!);

Write("Введите min значение массива: ");
int min = int.Parse(ReadLine()!);

Write("Введите max значение массива: ");
int max = int.Parse(ReadLine()!);

int[] positionArray = GetArray(length, min, max);
WriteLine($"[{String.Join(" ", positionArray)}]");

int sum = SumOddNumbers(positionArray);




int[] GetArray(int size, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

int SumOddNumbers(int[] positionArray)
{
    int result = 0;
    for (int i = 0; i < positionArray.Length; i++)
    {
        if (i % 2 == 1)
        {
            result += positionArray[i];
        }
    }
    return result;
}
WriteLine($"Сумма элементов нечетных позиций в массиве: {sum}");