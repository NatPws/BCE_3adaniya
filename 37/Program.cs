// считать строку из консоли, в нижнем ригистре. выяснить солько среди введенных букв гласных
//“hello” => 2
//“world” => 1

int CharCount(string word)
{
    int count = 0;
    char[] letters = { 'a', 'e', 'i', 'o', 'y', 'u' };

    for (int i = 0; i < word.Length; i++)
    {
        for (int j = 0; j < letters.Length; j++)
        {
            if (letters[j] == word[i])
            {
                count++;
                break;
            }
        }
    }
    return count;
}

Console.WriteLine("Введите слово: ");
string Input = Console.ReadLine();
Console.WriteLine(CharCount(Input));