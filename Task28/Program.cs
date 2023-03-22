// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120



Console.Clear();
Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int factDigit = FactDigit(number);

Console.WriteLine($"{number} -> {factDigit}");

int FactDigit(int num)
{
  int product = 1;
  for (int i = 2; i <= num; i++)
  {
    checked
    {
      product = product * i;
    }
  }

  return product;

}