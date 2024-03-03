/*
Задача 2: Напишите программу вычисления функции
Аккермана с помощью рекурсии. Даны два
неотрицательных числа m и n. 
Пример: m = 2, n = 3 -> A(m,n) = 9*/



int A(int n, int m)
    {
        if (n < 0 || m < 0) throw new ArgumentOutOfRangeException();
        if (n == 0) 
        {
            return m + 1;
        }
        if (m == 0) 
        {
            return A(n - 1, 1);
        }
        return A(n - 1, A(n, m - 1));
    }

int m = 3;
int n = 3;
int Akk = A(m, n);
       Console.WriteLine(Akk);
