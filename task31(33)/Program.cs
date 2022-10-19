/* **Задача 33:** Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

4; массив [6, 7, 19, 345, 3] -> нет

3; массив [6, 7, 19, 345, 3] -> да */

using static System.Console;
Clear();

Write("Print size of the array : ");
int length = int.Parse(ReadLine()!);
Write("Print min value of the array : ");
int min = int.Parse(ReadLine()!);
Write("Print max value of the array : ");
int max = int.Parse(ReadLine()!);

int[] array = GetArray(length, min, max);

string strArray = string.Join(",", array);
WriteLine($"[{strArray}]");

Write("Print a nunber : ");
int A = int.Parse(ReadLine()!);

FindNumber(array, A);



int[] GetArray(int size, int minValue, int maxValue)
{
Random rnd = new Random(); // переменная генератор случайных чисел
int[] result = new int[size];
for(int i = 0; i < result.Length; i++)
{
result[i] = rnd.Next(minValue, maxValue + 1);
}
return result;
}

void FindNumber(int[] ourArray, int ourNumber)
{

foreach (var item in ourArray)
{
if(item == ourNumber)
{
WriteLine($"There is your number {ourNumber} in the array");
return;
}
}
}