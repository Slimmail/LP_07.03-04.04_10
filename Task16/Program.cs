// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


Console.Clear();
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = SquadDetector(num1, num2);
Console.WriteLine(result ? $"{num1}, {num2} -> да" : $"{num1}, {num2} -> нет");

bool SquadDetector(int x1, int x2)
{
  return x1 == x2 * x2 || x2 == x1 * x1;
}


// Второй варинат:

// Console.Clear();
// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// string result = SquadDetector(num1, num2);
// Console.WriteLine(result);

// string SquadDetector(int x1, int x2)
// {
//   string d;
//   if (x1 == x2 * x2 || x2 == x1 * x1)
//   {
//     d = ($"{x1}, {x2} -> да");
//   }

//   else
//   {
//     d = ($"{x1}, {x2} -> нет");
//   }

//   return d;

// }