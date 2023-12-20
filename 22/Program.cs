// Сгенерировать массив (рандомные  дробные числа), найти разницу между минимальным и максимальным числом массива


double[] GenerateArray(int size, int leftRange, int rightRange)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
        {
            array[i] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 2);
        }
        return array;
}

void PrintArray(double[] arrayForPrint)
    {
        System.Console.Write("[ ");
        for (int i = 0; i < arrayForPrint.Length; i++)
            {
                System.Console.Write(arrayForPrint[i] + " ");
            }
        System.Console.Write(" ]");
        System.Console.WriteLine();
    }

    int ReadInt(string msg)
    {
        Console.Write(msg);
        return Convert.ToInt32(Console.ReadLine());
    }
    int FindMinInArray(double[] array)
    {
        int indexMin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[indexMin])
            {
                indexMin = i;
            }
        }
        return indexMin;
    }
    int FindMaxInArray(double[] array)
    {
        int indexMax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[indexMax])
            {
                indexMax = i;
            }
        }
        return indexMax;
    }

    int N = ReadInt("Введите размер массива: ");
        /* if (N < 1 || N > 8)
        {
            System.Console.WriteLine("Введено не корректное число! ");
            return;
        } */
    double[] myArray = GenerateArray(N, 0, 9);
    PrintArray(myArray);

    int iMin = FindMinInArray(myArray);
    int iMax = FindMaxInArray(myArray);
    System.Console.WriteLine($"Разница между {myArray[iMin]} и {myArray[iMax]} равна: {myArray[iMax] - myArray[iMin]}");
