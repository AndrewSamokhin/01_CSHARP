/*Задание 3*. Работа в сессионных залах

Напишите программу, которая принимает на вход
трёхзначное целое число и на выходе показывает сумму
первой и последней цифры этого числа.
456 => 10
782 => 9
918 => 17*/

int number = 918;
Console.WriteLine(number / 100 + number % 10);


int firstdigit = number / 100;
int lastdigit = number % 10;
Console.WriteLine(firstdigit + lastdigit);

//Console.WriteLine(number / 10);
//Console.WriteLine(number / 100);
//Console.WriteLine(number / 1000);

//Console.WriteLine(number % 10);
//Console.WriteLine(10 % 2 == 0); Условие четности

int a = (number / 100);
int b = (number % 10);
int sum = a + b;
Console.WriteLine(sum);




