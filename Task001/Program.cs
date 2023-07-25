﻿// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите планируемое кол-во чисел М  ");
int m = Convert.ToInt32(Console.ReadLine());
int[]InputNumbers(int plannedNumber)//Метод ввода М чисел 
{
int[] array = new int[plannedNumber];
int number = 1;
for (int i = 0; i < plannedNumber; i++)
{
    Console.WriteLine($"Введите {number} число  ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    number++;
}return array;
}
int NumberPositive(int[] array)//Метод поиска положительных чисел массива
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
void PrintArray(int[] array, string elem1, string elem2)
{
    Console.Write(elem1);
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]},");
        else
            Console.Write($"{array[i]}");
    }
    Console.Write(elem2);
}
int[] arr= InputNumbers(m);
PrintArray(arr, "[", "] -->");
Console.Write(NumberPositive(arr));
