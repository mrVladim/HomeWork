Console.WriteLine("Введите количество элементов");
int a = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int[a];

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, a);
    Console.Write(" " + Method (i) + " ");
 }

int Method (int a)
{
    return numbers[a];
}