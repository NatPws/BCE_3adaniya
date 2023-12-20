// Ввесмти массив, попарно умножив крайние элементы 
// Пример: [1, 2, 3, 4, 3, 2, 3] -> [3, 4, 9], у 4 пары нет. 

int[] array = { 2, 3, 3, 7, 5, 6, 3 };
int[] array1 = new int[array.Length / 2];
for (int i = 0; i < array1.Length; i++)
{
    array1[i] = array[i] * array[(array.Length - 1) - i];
    Console.Write(array1[i] + ",");
}
