// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа

// Console.WriteLine("Type any 3 numbers without space and I will show the second number");
// string i = Convert.ToString(Convert.ToInt32(Console.ReadLine()));
// Console.WriteLine("The second number is " + i[i.Length-2]);

// код тоже работает, но не поминаю как победить проблему ввода двух чисел или 4, 5, 6. 
// В этой ситуации программа показывает второе справа число

Console.WriteLine("Type any 3 numbers without spaces and I will show the second number");

int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string s = Convert.ToString(threeDigitNumber);
Console.WriteLine("The second number is " + s[1]);

//этот код лучше работает, но двузначные числа тоже принимает в расчет(