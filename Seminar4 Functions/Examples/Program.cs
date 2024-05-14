/*
int MyFunction(int a, string some_str, bool is_active)
{
    a++;
    return a;
}
int number = 10;
int result = MyFunction(number, "hello", false);
System.Console.WriteLine(result);
*/

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

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}

int[] FillArray(int[] array, int minValue, int maxValue)
{
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    foreach (int item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine("]");
}


int[] massive = GetRandomArray(10, 0, 10);
PrintArray(massive);

int[] massive2 = GetRandomArray(10, 100, 1000);
PrintArray(massive2);

massive2 = FillArray(massive2, 5, 15);
PrintArray(massive2);