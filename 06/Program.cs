﻿// Задать массив из 6 элементов, промежутов [-10, 10].
//Заменить отрицательные числа на положительные, а положительные на отрицательные

//Пример:
//[-3, 8, -6, 5, 10, 4]
// -> [3, -8, 6, -5, -10, -4]

int[] array = new int[6] {-3, 8, -6, 5, 10, 4}; 

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;  
    Console.Write($"{array[i]}, ");
}
