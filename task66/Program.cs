// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumMToNNumber(int m, int n)
{
  int sum = 0;
  if (n == m)
  {
    return n;
  }
  else if (n > m)
  {
    sum = n + SumMToNNumber(m, n - 1);
    return sum;
  }
  else return -1;
}

int m = ReadNumber("Введите число M: ");
int n = ReadNumber("Введите число N: ");

if (n > m) Console.Write(SumMToNNumber(m, n));
if (n < m) Console.Write(SumMToNNumber(n, m));