//// Написать программу, которая выбирает 3-e число в введенном пользователем 
//числе и выводит его

Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());
if (number > 100)
{ 
    while (number > 999)
    { number = number / 10;
    }
    int result = number % 10;
    Console.WriteLine($"Третья цифра: {result}");
}
else
{
    Console.WriteLine("Введите число по-больше");
}
