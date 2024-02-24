// Расчет числа Фиббоначи
/*
int Fibb(int i)
{
    //1, 1, 2, 3, 5, 8
    if (i == 1 || i == 2)
    {
        return 1;
    }
    return Fibb(i - 1) + Fibb(i - 2);

}

//Console.WriteLine(Fibb(4));

for(int i = 1; i < 100; i++)
{
    Console.WriteLine($"Fibb ({i}) = {Fibb(i)}");
}
*/


int size = 100;
int[] fibbs = new int[size];

fibbs[0] = 1;
fibbs[1] = 1;

for (int i = 0; i < 100; i++)
{
    if (i >= 2)
    {
        fibbs[i] = fibbs[i - 1] + fibbs[i - 2];
    }
    Console.WriteLine($"Fibb ({i}) = {fibbs[i]}");
}

