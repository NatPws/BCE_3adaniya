// адайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”


char[] letters = {'a', 'b', 'c', 'd'};
string str = "";
for(int i = 0; i < letters.Length; i++)
{
    str = str + letters[i];
    str += " "; 
}
System.Console.WriteLine(str);

// либо так:
// вместо цикла for: string str2 = string.Concat(letters);

// либо так:
// вместо цикла for: string str3 = string.Join(", ", letters);   - хорошая команда для вывода красивого массива

___________________________________________________________________________________________________________________

/*  На основе символов строки (тип string) сформировать массив
символов (тип char[]). Вывести массив на экран.
Указание
Метод строки ToCharArray() не использовать.
Пример
“Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] */

char[] ToCharArray(string word)
{
    char[] text = new char[word.Length];
    for (int i = 0; i < word.Length; i++)
    {
        text[i] = word[i];
    }
    return text;
}

void PrintArray(char[] Array)
{
    Console.WriteLine(string.Join(", ", Array));
}

Console.WriteLine("напишите слово");
string inputString = Console.ReadLine();

char[] charsArray = ToCharArray(inputString);
PrintArray(charsArray);
