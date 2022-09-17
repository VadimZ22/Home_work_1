Console.Clear();
Console.WriteLine("Введите число!");
double num = double.Parse(Console.ReadLine());
if (num % 2 == 0)
    Console.WriteLine("Число четное!");
else Console.WriteLine("число нечетное!");