Console.Write("Enter row:");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Enter column:");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
int n = 5; 
int m = 7;
Random random = new Random();
int[,] arr = new int[n, m];
Console.WriteLine("Array");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(10, 99);
        Console.Write("{0} ", arr[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine();
if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
{
    Console.WriteLine("The element doesn't exist in this array");
}
else
{
    Console.WriteLine("Element = {0}", arr[pos1, pos2]);
}
