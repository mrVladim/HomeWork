﻿Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("Первое число " + num1 + " больше чем второе " + num2);
}
else
{
    Console.WriteLine("Второе число " + num2 + " больше чем первое " + num1);
}