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

/*  // с этим нужно еще разобраться что это такое!
void FilltArray(int[] collection)
{
   int length = collection.Length;
   int index = 0;
    while (index < length)
    {
      collection[index] = new Random().Next(1,10); 
      index++;
    }
}

void PrintArray(int[] col)
{
   int count = col.Length;
   int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]); 
        position++;
    }
}
 */