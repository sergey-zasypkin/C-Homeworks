// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Random random = new Random();
int m = random.Next(1, 10);
int n = 100;
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

PrintSumm(m, n, temp=0);

void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Sum = {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}
