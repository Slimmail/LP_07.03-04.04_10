// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Clear();

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());


if (m <= n) // Проверяем, что M и N положительные и M <= N
{
  int sum = Sum(m, n); // Вызываем рекурсивную функцию для подсчета суммы

  Console.WriteLine("Сумма натуральных элементов в промежутке от {0} до {1} равна {2}", m, n, sum);
}
else if (m >= n)
{
 int temp = m;
 m = n;
 n = temp; 

 int sum = Sum(m, n); // Вызываем рекурсивную функцию для подсчета суммы

  Console.WriteLine("Сумма натуральных элементов в промежутке от {0} до {1} равна {2}", m, n, sum);
}
else
{
  Console.WriteLine("Ошибка ввода значений!");
}


int Sum(int num1, int num2)
{
  if (num1 == num2) return num1;  // заканчиваем рекурсию

  else // Рекурсивный случай
  {
    return num1 + Sum(num1 + 1, num2);
  }
}
