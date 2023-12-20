// Написать программу, которая принимает на ввод 2 числа и проверяет,
// является ли второе кратным первому, если нет - выводит остаток

//Пример:

// 16, 5 -> нет, 1;
// 9, 3 -> да;
// 8, 5 -> нет, 3;

Console.WriteLine("Введите первое число:  ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:  ");
int number2 = Convert.ToInt32(Console.ReadLine());


if (number1 % number2 == 0)
{   
    Console.WriteLine("да");
}
else
{   int result = number1 % number2;
    Console.WriteLine($"нет, {result}");
}