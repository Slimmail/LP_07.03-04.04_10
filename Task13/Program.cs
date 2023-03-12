// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 && num > -100)
{
  Console.WriteLine($"{num} -> Третьей цифры нет");
}
else
{
  int res = GetThreeDigitPosition(num);
  Console.WriteLine($"{num} -> {res}");
}


int GetThreeDigitPosition(int x)
{
  if (x < 0)
   x = x * -1;
   while (x >= 1000)
  {
    x = x / 10;
  }
  int result = x % 10;
  return result;
}