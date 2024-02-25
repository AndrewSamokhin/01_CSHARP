/*
Задание 1. Совместная работа
Семинар 3. Массивы
15 мин
Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве. Программа
должна выдать ответ: Да/Нет.
Примеры
[1 3 4 19 3], 8 => Нет
[-4 3 4 1], 3 => Да*/

int[] arr = { 1, 3, 4, 19, 3 };
int a = 5;
bool inArray = false;

/*for (int i = 0; i < arr.Length; i++)
{
    if (a == arr[i])
    {
        inArray = true;
            }
}*/

foreach(int i in arr)
{
    if(a == i)
    {
        inArray = true;
    }
}

if(inArray)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
