// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Random random = new Random();
int m = random.Next(1, 10);
int n = random.Next(1, 10);

int functionAkkerman = Ack(m, n);

Console.Write($"Accerman function = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}
