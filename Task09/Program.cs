// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// if (firstDigit > secondDigit) 
//   Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// else 
//   Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

// ///////////////////////////////////////////////////////////
// //Ниже показан тернарный оператор (аналог if else )
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

//////////////////////////////////////////////////////////

int result = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {result}");

int MaxDigit(int num)  // num = 78
{
  int firstDigit = num / 10;
  int secondDigit = num % 10;
  int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
  return maxDigit;
}


