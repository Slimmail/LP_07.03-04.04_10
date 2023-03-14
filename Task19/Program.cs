// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

string getReason = GetReason(number) ? "Да" : "Нет";
Console.Write($"{number} -> {getReason}");

bool GetReason(int num)
{
  if (num >= 10000 && num <= 99999)
    {
      int digitPosition1 = num /10000 % 10;
      int digitPosition2 = num /1000 % 10;
      int digitPosition4 = num /10 % 10;
      int digitPosition5 = num % 10;
        if (digitPosition1 == digitPosition5 && digitPosition2 == digitPosition4)
        {
          return true;
        }
    }
  return false;
}