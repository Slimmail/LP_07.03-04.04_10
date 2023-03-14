

Console.Clear();
Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

TableCube(num);

void TableCube(int number)
{
  int count = 1;
  while (count <= number)
  {
    int cube = count * count * count;
    Console.WriteLine($"{count, 2} -> {cube, 3}");
    count++;
  }

}
