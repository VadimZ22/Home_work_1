Console.Clear();
double[] mass = new double[3];
Console.WriteLine("Enter three numbers!");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Enter a number:");
    mass[i] = double.Parse(Console.ReadLine());
}

double max = mass[0];
for (int i = 0; i < 3; i++)
{
    if (mass[i] > max) max = mass[i];
}
Console.WriteLine($"{max}");