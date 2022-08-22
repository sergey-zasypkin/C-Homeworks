// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

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

int sum = 0;
for (int i = 0; i < numbers.Length; i++)
if (i % 2 == 1) sum = sum + numbers[i];

Console.WriteLine("The sum of array elements on uneven position is " + sum);