// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.Write("Веведите целое число A");
// double numberA = Convert.ToInt64(Console.ReadLine());

// Console.Write("Веведите целое число B");
// double numberB = Convert.ToInt64(Console.ReadLine());



// Console.WriteLine(number);

// int finalResult = RemoveSecondDigit(number);

// int RemoveSecondDigit(int num)
// {
//   int firstDigit = num / 100;
//   int thirdDigit = num % 10;
//   int result = firstDigit * 10 + thirdDigit;
//   return result;
// }

// Console.WriteLine(finalResult);


Console.Clear();
Console.Write("Введите первое число: ");
int firstNumber = ReadConsole();
Console.Write("Введите второе число: ");
int secondNumber = ReadConsole();

int result = IsMultiplicity(firstNumber, secondNumber) ;

if(result == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine($"не кратно, остаток {result}");
}

int IsMultiplicity(int number1, int number2)
{
    return number1 % number2;    
}

int ReadConsole()
{
    var str = Console.ReadLine();
    int number = Convert.ToInt32(str);

    return number;
}
