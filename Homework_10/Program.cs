int CountVowels(string[] words)
{
    string[] vowels = {"а", "е", "ё", "и", "о", "у", 
    "ы", "э", "ю", "я", "a", "e", "i", "o", "u", "y"};
    int counter = 0;
    for (int i = 0; i < words.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if(words[i][0] == vowels[j][0])
                counter++;
        }
    }
    return counter;
}

string[] StringGlue(string[] words)
{
    int size = words.Length/2;
    string[]glued = new string[size];
    
    for (int i = 0,j=0; i < words.Length; i=i+2,j++)
    {
        glued[j] = words[i] + words[i+1];
    }
    return glued;
}

void ShowWords(string[] words)
{
    for (int i = 0; i < words.Length; i++)
        Console.Write(words[i] + " ");
    Console.WriteLine();
}

string[] words = {"кро", "мыш", "аба", "щер", "утк", "ось", "ску", "кур"};

/*
Задача 1: 
Задайте массив строк. Напишите программу, 
которая считает кол-во слов в массиве, начинающихся на гласную букву.

Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1
*/

Console.WriteLine("Number of vowels is: " + CountVowels(words));

/*
Задача 2: 
Задайте массив строк. Напишите программу, которая генерирует новый массив, 
объединяя элементы исходного массива попарно.

Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} 
-> { "qwewer", "ertrty", "tyuyui"}
*/

ShowWords(StringGlue(words));
