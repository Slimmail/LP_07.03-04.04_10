// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = GetTwoDigitPosition(number);
Console.WriteLine($"{number} -> {result}");

int GetTwoDigitPosition(int num)
{
  int twoDigitPosition = num / 10 % 10;
  return twoDigitPosition;
}

