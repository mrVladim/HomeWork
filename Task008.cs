int u = 1;
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Четные числа от 1 до " + N);
bool not = true;
while (u <= N)
{
    if (u % 2 != 1)
    {
        Console.Write(u + ", ");
        not = false;
    }
    u++;
}
if (not)
{
    Console.WriteLine("Нет чётных чисел");
}