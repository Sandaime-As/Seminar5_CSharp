/* **Задача 37:** Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3

[6 7 3 6] -> 36 21 */

using static System.Console;
Clear();
Write("Введите размер массива: ");
int length = int.Parse(ReadLine()!);
Write("Введите мин значение массива: ");
int min = int.Parse(ReadLine()!);
Write("Введите макс значение массива: ");
int max = int.Parse(ReadLine()!);
int[] array = GetArray(length,min, max);
WriteLine($"[{String.Join(" | ", array)}]");

int [] array1 = MultElement (array);
WriteLine($"[{String.Join(" | ", array1)}]");




int [] MultElement(int [] array){
    int len = array.Length;
    int size = len/2 + len%2;
    int [] multarray = new int [size];
    for(int i=0; i < size; i++){
        if (i != len - 1 - i)
        {
        multarray[i] = array[i] * array[len - 1 - i];            
        }
        else{multarray[i] = array[i];}
    }
    return multarray;
}





int[] GetArray(int size,int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue+1);
    }
    return result;
}





