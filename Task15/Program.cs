// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Type number of the day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckDayOfWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine(dayNumber + "-> yes, it's a holiday");
  }
  else if (dayNumber < 1 || dayNumber > 7) 
  {
    Console.WriteLine(dayNumber + "-> it's not a day of the week");
  }
  else Console.WriteLine(dayNumber + "-> no, it's a working day");
}

CheckDayOfWeek(dayNumber);
