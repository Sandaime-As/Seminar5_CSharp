/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

using static System.Console;
Clear();
Write("Введите размер массива: ");
int length=int.Parse(ReadLine()!);
int[] array=GetArray(length);
WriteLine($"[{String.Join(" ",array)}]");          


int evenNumbers=0;
foreach (int element in array)
{
    if(element%2==0)
    {
        evenNumbers++; 
    }
}
WriteLine($"Колличество четных чисел в массиве: {evenNumbers}"); 

int[] GetArray(int size)
{
    Random rnd=new Random();
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i]=rnd.Next(100, 1000-1);
    }
    return result;
}