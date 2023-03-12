// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Clear();
Console.WriteLine("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

int day = DayDetector(num);
// Console.WriteLine(day);

if (day == 1)
{ 
  Console.WriteLine($"{num} -> нет"); 
}
else if (day == 2)
{
  Console.WriteLine($"{num} -> да");
}
else if (day == 3)
{
  Console.WriteLine($"{num} -> такого дня не существует");
}


int DayDetector(int x)
{
  int d = 0;
  if (x == 1 ^ x == 2 ^ x == 3 ^ x == 4 ^ x == 5)
  {
    d = 1;
  }

  else if (x == 6 ^ x == 7)
  {
    d = 2;
  }

  else
  {
    d = 3;
  }

  return d;

}