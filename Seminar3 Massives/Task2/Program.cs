﻿/*Задание 2. Работа в сессионных залах
Семинар 3. Массивы
Задайте массив из 10 элементов, заполненный числами из
промежутка [-10, 10]. Замените отрицательные элементы на
положительные, а положительные на отрицательные.
Пример
[1 -5 6]
=> [-1 5 -6]
*/

int[] array = {1, -5, 6};
for (int i = 0; i < array.Length; i++)
{
    array [i] = -array[i];
} 

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");;
} 

