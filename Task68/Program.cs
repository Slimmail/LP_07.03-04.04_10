// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите значение M: ");
int numM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int numN = Convert.ToInt32(Console.ReadLine());
if(numM < 0 || numN < 0)
{
 Console.WriteLine("Задано неверное значение");
 Console.WriteLine("вводите целые положительные числа");
}
else
{
int akermanFunc = AkermanFunc(numM, numN);
Console.WriteLine($"При m = {numM} и n = {numN} -> A(m, n) = {akermanFunc}");
}

int AkermanFunc(int n, int m)
{
    while (n != 0)
    {
        if (m == 0) m = 1;
        else m = AkermanFunc(n, m - 1);
        n = n - 1;
    }
    return m + 1;
}
