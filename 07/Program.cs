﻿// Задать массив. Написать программу, которая определяет, 
// присутствует ли заданное число в массиве
// и выдает ответ: Да/Нет

//Пример
//(1, 5, 13, 24, 7, 9), 8 -> Нет
//(1, 3, 2, 17), 3 -> Да

int number = 9;
int[] array = new int[6] { 1, 3, 2, 17, 18, 11 };
bool flag = false;
for (int i = 0; i < array.Length; i++)
{
    if (number == array[i])
    {
        flag = true;
        break;
    }
}

if (flag)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}