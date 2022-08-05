// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Подразумеваем простые числа

Console.Write("Type the first number:");
string S1 = Console.ReadLine();
int numberA = int.Parse(S1);

if (numberA % 2 == 1)
{
    Console.WriteLine("uneven");
}
else
{
    Console.WriteLine("even");
}
