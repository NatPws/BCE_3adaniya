﻿// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите число Х: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

{
    if ( X > 0 && Y > 0)
    {
        Console.WriteLine("1");
    }
    else if (X < 0 && Y > 0)
    {
        Console.WriteLine("2");
    }
    else if (X < 0 && Y < 0)
    {
        Console.WriteLine("3");
    }
    else if (X > 0 && Y < 0)
    {
        Console.WriteLine("4");
    }
    else
    {
        Console.WriteLine("Ошибка, число X и Y не должно быть равно 0");
    }
}