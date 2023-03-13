// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Clear();
Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

bool result = MultTwoNumbers(number1, 7, 23);

Console.WriteLine(result? "Да" : "Нет");

bool MultTwoNumbers(int num, int num1, int num2)
{
  return num % num1 == 0 && num % num2 == 0;
}


// Console.WriteLine(CheckNum(num));

// string CheckNum(int x)
// {
//   string d = ($"{x} -> нет");
//   if (x % 7 == 0)
//   {
//     if (x % 23 == 0)
//     {
//       d = ($"{x} -> да");
//     }
//   }
//   return d;
// }