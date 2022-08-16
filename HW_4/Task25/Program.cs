// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Enter any number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number and I will exponentiate the first number: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = 1;

for(int i = 1; i < b || i == b; i++)
{
    result = result * a;
}
Console.WriteLine(result);