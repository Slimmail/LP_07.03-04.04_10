// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Введите возводимое в степень число: ");
int dig = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень возводимого числа: ");
int lev = Convert.ToInt32(Console.ReadLine());



// int dig = 2;
// int lev = 4;

int getDigitalLevel = GetDigitalLevel(dig, lev);

Console.WriteLine($"{dig}, {lev} -> {getDigitalLevel}");

int GetDigitalLevel(int digit, int level)
{
    int sum = 1;
    for (int i = 1; i <= level; i++)
    {
      sum = sum * digit;
    }
    return sum;
  
}



