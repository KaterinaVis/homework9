﻿// Показать натуральные числа от N до 1, N задано (с помощью рекурсии)

Console.WriteLine("Введите натуральное число");
int n = Convert.ToInt32(Console.ReadLine());
int count = 2;
PrintNumber(n, count);
Console.Write(1);

void PrintNumber(int num, int a)
{
  if (a > num) return;
  PrintNumber(num, a + 1);
  Console.Write(a + ",");
}




