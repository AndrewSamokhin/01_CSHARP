int Fibb(int i)
{
    //1, 1, 2, 3, 5, 8
    if (i == 1 || i == 2)
    {
        return 1;
    }
    return Fibb(i - 1) + Fibb(i - 2);

}

for(int = 1; int < 100; i++)
{
    Console.WriteLine(Fibb(4));
}


int size = 100:
int[] fibbs = new int[size];
Fibb[0] = 1;
Fibb[1] = 1;

for (int i = 0; i < 100; i++)
{
    if (i >= 2)
    {
        fibbs[i] = fibbs[i - 1] + fibbs[i - 2]
    }
}
