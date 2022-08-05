//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// N - простое число.

Console.Write("Type the number:");
string S1 = Console.ReadLine();
int numberA = int.Parse(S1);

int numberI = 1;

while(numberI <= numberA)
{
    if(numberI % 2 == 0)
    {
        Console.Write(numberI + " ");
        numberI = numberI + 1;
    }
    else
    {
        numberI = numberI + 1;
    }
}
