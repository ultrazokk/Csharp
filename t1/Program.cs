// ДЗ к 3 семинару, задача 1.
// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int[] numbers = new int[10];
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(1, 101);
    }

    int countInRange = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] >= 20 && numbers[i] <= 90)
        {
            countInRange++;
        }
    }

    Console.WriteLine("Полученный массив: ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine($"Количество элементов масива в диапазоне от 20 до 90: {countInRange}");
