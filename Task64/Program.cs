// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n =0;

while (n <= 0)
{

Console.WriteLine();
Console.Write("Введите N: ");
n = Convert.ToInt32(Console.ReadLine());

if (n <= 0) 
{
 Console.Clear(); 
 Console.WriteLine($"Задано неверное значение N: {n}");
 Console.WriteLine("вводите целые положительные числа");

}
}



Console.Write($"N = {n} -> ");
Recursia(n);

void Recursia(int x)
{
    if (x == 1) Console.Write(x); 
    if (x == 1) return;
    Console.Write($"{x}, ");
    
    Recursia (x - 1);

}

