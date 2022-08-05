//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Под числами понимаем простые числа. Числа вводятся пользователем.

Console.Write("Type the first number:");
string S1 = Console.ReadLine();
int numberA = int.Parse(S1);
Console.Write("Type the second number:");
string S2 = Console.ReadLine();
int numberB = int.Parse(S2);

if(numberA > numberB)
{
    Console.WriteLine("Number " + numberA + " is bigger than number " + numberB );
}
else
{
    Console.WriteLine("Number " + numberB + " is bigger than number " + numberA );
}