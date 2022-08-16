// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Enter a multi-digit number and I will show the sum of its digits: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while(a > 0)
{
    sum = sum + a%10;
    a = a/10;
}

Console.WriteLine(sum);
