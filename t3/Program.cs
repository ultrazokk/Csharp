double[] numbers = { 2.3, 3.3, 4.3, 5.3, 6.3}; 

double min = numbers[0];
double max = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}

double difference = max - min;

Console.WriteLine("Массив вещественных чисел:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {difference}");