// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int finalResult = RemoveSecondDigit(number);

int RemoveSecondDigit(int num)
{
  int firstDigit = num / 100;
  int thirdDigit = num % 10;
  int result = firstDigit * 10 + thirdDigit;
  return result;
}

Console.WriteLine(finalResult);




// int x = 456 % 10;
// Console.WriteLine(x);
