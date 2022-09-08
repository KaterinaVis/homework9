// Найти сумму элементов от M до N, N и M заданы


Console.WriteLine("Введите число от");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число до");
int n = Convert.ToInt32(Console.ReadLine());

int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

Sum(m, n, temp=0);

void Sum(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Сумма между элементами = {sum} ");
    return;
  }
  Sum(m, n - 1, sum);
}
