// Задача 4; Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. 

// Пример
// 2,3,7-> 7
//  44, 5, 78 -> 78
// 22,3, 9 -> 22



Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());

int numMax = num1;
if (num1 < num2)
{
  numMax = num2;
}
if (numMax < num3)
{
  numMax = num3;
}
Console.WriteLine($"Максимальное число {numMax}");


