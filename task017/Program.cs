﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Write("Ведите числа: ");
string[] numbers = Console.ReadLine()!.Split(',');
int count = 0;
int size = numbers.Length;
for (int i = 0; i < size; i++)
{
   int num = int.Parse(numbers[i]);
   if (num > 0)
   {
    count++;
   }
}
Console.WriteLine($"Количество чисел больше нуля = {count}");
