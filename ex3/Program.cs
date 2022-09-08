// Найти сумму элементов от M до N, N и M заданы


Console.WriteLine("Введите число от");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число до");
int n = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int number =
SumNumber(n, m);
// Console.Write(sum);

void SumNumber(int n, int m)
{
  if (count > n) return;
  SumNumber(n, count + 1);
  Console.Write(count + ",");
}
