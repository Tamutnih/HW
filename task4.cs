﻿// Напишите программу, которая на вход принимает на вход три числа и выдает максимальное из этих чисел.
// 2,3,7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 3 -> 22

Console.WriteLine("Введите три числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{ 
    max = num3;
}
Console.WriteLine("Наибольшее из введенных чисел -> " + max);