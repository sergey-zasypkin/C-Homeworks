// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

static int[] createArray(int number)
{
    int[] array = new int[number];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = i + 1;
    }
    return array;
}

static void writeArray(int[] array)
{
    foreach(int number in array)
    {
        Console.Write(number + " ");
    }
}
static int[] Shuffle(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        int j = new Random().Next(0, i + 1);
        int number = array[i];
        array[i] = array[j]; 
        array[j] = number;
    }
    return array;
}

writeArray(Shuffle(createArray(10)));