Console.Clear();
Console.WriteLine("Введите число!");
double num = double.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    if (i % 2 == 0) Console.Write($"{i} ");
    else continue;
}
