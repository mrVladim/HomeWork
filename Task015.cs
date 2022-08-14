Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void DayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("нет такого днгя недели");
  }
  else Console.WriteLine("(этот день выходной?) -> нет");
}

DayOfTheWeek(dayNumber);