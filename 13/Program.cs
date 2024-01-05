// Задайте одномерный массив из 10 целыхчисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

// Пример: массив [10 21 14 93 23] => 2

int[] array = new int[10] { 1, 8, 6, 12, 48, 34, 99, 29, 30, 14 };
int  count = 0;
for (int i = 0; i < 10; i++)
{
    if (array[i] >= 20 && array[i] <= 90)
    {
    count = count + 1;
    }   
}

Console.WriteLine(count);

_______________________________________________________________________________________________________________________
// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.


Console.WriteLine("Введите число из отрезка [10, 99]: ");
int number = Convert.ToInt32(Console.ReadLine());

{
    int maxNumber = 0;
    int firstNum = number / 10;
    int secondNum = number % 10;
    if (firstNum > secondNum)
    {
        maxNumber = firstNum;
    }
    else
    {
        maxNumber = secondNum;
    }
    Console.WriteLine(maxNumber);
}