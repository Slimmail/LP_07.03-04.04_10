// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.

// Пример

// а=5; Ь = -> mах = 7
// а = 2 Ь = 10 -> mах = 10
// а = -9 b = -3 -> mах = -3

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) 
{
  Console.WriteLine($"Первое число {num1} больше, чем второе число {num2}");
}
else 
{
  Console.WriteLine($"Второе число {num2} больше, чем первое число {num1}");
}