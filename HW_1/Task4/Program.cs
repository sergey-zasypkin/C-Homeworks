// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.Write("Type the first number:");
string S1 = Console.ReadLine();
int numberA = int.Parse(S1);

Console.Write("Type the second number:");
string S2 = Console.ReadLine();
int numberB = int.Parse(S2);

Console.Write("Type the third number:");
string S3 = Console.ReadLine();
int numberC = int.Parse(S3);

int max = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.WriteLine("Max is " + max);