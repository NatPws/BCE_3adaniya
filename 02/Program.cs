//Найти на каком индексе массива расположена цифра, которую ищем

int[] array = {123, 581, 13, 93, 75, 15, 9, 1 };

int n = array.Length;
int find = 13;

int index = 0;

while (index < n)
{
 
    if(array[index] == find)
    {
        Console.WriteLine(index);
        // Если в массиве было несколько одинаковых значений,
        // решаем это добавлением комаелы:
        break;
    }
    index++;
}