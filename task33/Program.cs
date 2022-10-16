/* **Задача 31:** Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.

Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20. */

using static System.Console;
Clear();
Write("Enter the size of array: ");
int length=int.Parse(ReadLine()!);

Write("Enter the minValue of array: ");
int min=int.Parse(ReadLine()!);

Write("Enter the maxValue of array: ");
int max=int.Parse(ReadLine()!);

int[] array=GetArray(length,min,max);
//string stringArray=String.Join(",",array);        //После String.Join в кавычках писать всё, что захочется (разделитель)
WriteLine($"[{String.Join(" ",array)}]");           //можно в параметрический вывод указать так <--- сокращая код.

int positiveSum=0;
int negariveSum=0;

foreach (var element in array)
{
    if(element>0)
    {
        positiveSum+=element;
    }
    if(element<0)
    {
        negariveSum+=element;
    }
}
WriteLine($"negativeSum={negariveSum}, positiveSum={positiveSum}");


int[] GetArray(int size, int minValue, int maxValue)
{
    Random rnd=new Random();
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i]=rnd.Next(minValue, maxValue+1);
    }
    return result;
}