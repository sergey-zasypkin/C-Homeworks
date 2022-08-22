// Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Type the size of an array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

static int[] createArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
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

int EvenNumber = 0;
for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
EvenNumber++;

Console.WriteLine("Count of even numbers is: " + EvenNumber);