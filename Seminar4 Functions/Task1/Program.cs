/*Задание 1. Совместная работа
Семинар 4. Функции

Задайте одномерный массив, заполненный случайными
числами. Определите количество простых чисел в этом
массиве.
Примеры
[1 3 4 19 3] => 2
[4 3 4 1 9 5 21 13] => 3*/

/*
int minValue = 10, maxValue = 99;
int[] array = new int[10];
var rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(minValue, maxValue + 1);
    Console.WriteLine(array[i]);
} 
*/

bool IsPrime(int number)
{
    if (number == 1)
    {
        return false;
    }

    for(int i = 2; i < number; i++)
    {
        if(number % i == 0)
        {
            return false;
        }

    }
    return true;
}

int GetCountPrimeNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (IsPrime(array[i]))
        {
            count++;
        }
    }
    return count;
}

//int [] array = {1, 3, 4, 19, 3};
int [] array = {4, 3, 4, 1, 9, 5, 21, 13};

System.Console.WriteLine(GetCountPrimeNumbers(array));


//for(int i = 2; i < 10; i++)
//{
//    System.Console.WriteLine($"{i} {IsPrime(i)}");
//}