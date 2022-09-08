// Показать натуральные числа от M до N, N и M заданы (с помощью рекурсии)

Console.WriteLine("Введите число от");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число до");
int n = Convert.ToInt32(Console.ReadLine());

int count = m+1;
PrintNumber(n, count);
Console.Write(m);

void PrintNumber(int n, int count)
{
  if (count > n) return;
  PrintNumber(n, count + 1);
  Console.Write(count + ",");
}

