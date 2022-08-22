// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Type the size of an array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

static int[] createArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 100);
    }
    return numbers;
}

static void writeArray(int[] numbers)
{
    foreach(int number in numbers)
    {
        Console.Write(number + " ");
    }
}

writeArray(createArray(numbers));
Console.WriteLine();

int min = numbers[0];
int max = numbers[0];
for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] > max) max = numbers[i];
    if(numbers[i] < min) min = numbers[i];
}
int result = max - min;
Console.WriteLine("Max element is " + max);
Console.WriteLine("Min element is " + min);
Console.WriteLine("The difference between max and min is " + result);