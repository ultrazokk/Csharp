// Задайте массив на 10 целых чисел. Напишите программу, 
// которая определяет количество чётных чисел в массиве.

    int[] numbers = new int[10]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int countEven = CountEvenNumbers(numbers);

        // Выводим результат
    Console.WriteLine("Сгенерированный массив:");
    for (int i = 0; i < numbers.Length; i++)
    {
         Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine($"Количество четных чисел в массиве: {countEven}");
    
    static int CountEvenNumbers(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }


