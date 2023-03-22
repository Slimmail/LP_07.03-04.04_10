// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12




int CheckDigitInNumber (int number)
{
  if (number < 0) 
  {
    number *= -1;
  }
  // if (number > -100 && number < 100) 
  // {
  //   return 2;
  // }
  int numberLength = 1;
  while (numberLength <= number)
  {
    number /= 10;
    numberLength++;
  }
  return numberLength;
}

//                      5       12345
int GetSumDigit(int digNum, int num)
{
  int sum = 0;
  int x = 1;
   for (int i = 0; i < digNum; i++)
   {
    int digitForSum = num / x % 10;
    sum = sum + digitForSum;
    x *= 10;
   } 
    return sum;
}
int CheckDigitPozNeg (int num)
{
if (num < 0)
  {
    return num * -1;
  }
return num;
}



Console.Clear();
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

// int num = -200; // временно
int numFresh = CheckDigitPozNeg(num);
int digSize = CheckDigitInNumber(num);



Console.Write($"{num} -> сумма цифр в числе:  ");
Console.Write(GetSumDigit(digSize, numFresh));


// Console.WriteLine(numFresh);
// Console.WriteLine("кол-во символов: " + digSize);
// Console.WriteLine(GetSumDigit(5, 12345)); // =15











