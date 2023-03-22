// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5



Console.Clear();
Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine()); 

int sumNumbers = CountDigit(number);

Console.WriteLine($"{number} -> {sumNumbers}");

int CountDigit(int num)
{
   int count = 0;

   while (num !=0)
   {
    num /=10;
    count++;
    }
   
   return count;
  
}
