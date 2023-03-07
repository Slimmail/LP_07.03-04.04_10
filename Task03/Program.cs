// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите номер дня: ");
// string day = Console.ReadLine();
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1)
{
  Console.Write("Понедельник");
}
else if (day == 2)
{
  Console.Write("Вторник");
}
else if (day == 3)
{
  Console.Write("Среда");
}
else if (day == 4)
{
  Console.Write("Четверг");
}
else if (day == 5)
{
  Console.Write("Пятница");
}
else if (day == 6)
{
  Console.Write("Суббота");
}
else if (day == 7)
{
  Console.Write("Воскресенье");
}
else if (day > 7)
{
  Console.Write("Такого дня недели не существует!");
}
