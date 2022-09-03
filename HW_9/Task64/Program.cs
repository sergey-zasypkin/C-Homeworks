//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Random random = new Random();
int n = random.Next(1,10);
int count = 2;
PrintNumber(n, count);
Console.Write(1);

void PrintNumber(int n, int count)
{
  if (count > n) return;
  PrintNumber(n, count + 1);
  Console.Write(count + ", ");
}