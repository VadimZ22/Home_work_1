Console.Clear();
Console.WriteLine("Введите два числа!");
int num_1 = int.Parse(Console.ReadLine());
int num_2 = int.Parse(Console.ReadLine());

if (num_1 < num_2)
    Console.WriteLine($"max = {num_2}, min = {num_1}");
if (num_1 > num_2)
    Console.WriteLine($"max = {num_1}, min = {num_2}");
else Console.WriteLine("the numbers are equal");
