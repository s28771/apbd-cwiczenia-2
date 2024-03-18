// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("modyfikacja gita");
Console.WriteLine("modyfikacja gita 2 ");
Console.WriteLine("modyfikacja gita 3 ");

static double GetAverage(int[] numbers)
{
    int sum1 = 0;
    foreach (var number in numbers)
    {
        sum1 += number;
    }

    return (double)sum1 / numbers.Length;
}

int[] numbers = {1,2,3,4};
double average = GetAverage(numbers);
Console.WriteLine(average);

static int MaxValuee(int[] array)
{
    return array.Max();
}