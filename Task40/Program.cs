// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


Console.Clear();
Console.WriteLine("Введите 1-е число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2-е число");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 3-е число");
int number3 = Convert.ToInt32(Console.ReadLine());

bool result = Triangle(number1, number2, number3);
Console.WriteLine(result ? "Существует" : "Не существует");

bool Triangle(int num1, int num2, int num3)
{
  return num1 + num2 > num3 && num2 + num3 > num1 && num3 + num1 > num2;
}



// dotnet run