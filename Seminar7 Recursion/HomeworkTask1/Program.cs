﻿/*Задание
Задача 1: Задайте значения M и N. Напишите
программу, которая выведет все натуральные числа
в промежутке от M до N. Использовать рекурсию, не
использовать циклы.
Пример
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"
*/


void RangeOfDigit(int n, int m)
{
    if (m == n)
    {
        Console.WriteLine(m);
        return;
    }
    Console.Write(m + ", ");
    RangeOfDigit(n, m + 1);
}
int m = -5;
int n = 34;

RangeOfDigit(n, m);


