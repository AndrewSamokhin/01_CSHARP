int[] array = {1, 2, 3};

int min = array[0];

    // int min = int.MaxValue; для определения минимума надо взять 
    // максимально возможное в int

foreach (var item in array)
{
    //  min = item < min ? item : min;  Оператор if else 
    //  тут записано условие, при выполнении присвоить item, если нет, то оставить min 
    //  после "?" возвращается  true, после ":" возвращается false.
    //  min = item < min ? item : min; 
    // 

    if (item < min)   
    {
        min = item;
    }
}
System.Console.WriteLine(min);