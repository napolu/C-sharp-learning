/*
int CountEven(string[] words)
{
    int count = 0;
    for (int i = 0; i < words.Length; i++)
    {
        if(words[i].Length % 2 == 0) count++;
    }
    return count;
}
string[] names = {"Pavel", "Anna", "Denis", "Max", "Denal"};
//Console.WriteLine(CountEven(names));

string[] StringArraySort(string[] words)
{
    string temp = string.Empty;
    for (int i = 0; i < words.Length-1; i++)
    {
        for (int j = 0; j < words.Length-1-i; j++)
        {
            if(words[j].Length > words[j+1].Length)
            {
                temp = words[j];
                words[j] = words[j+1];
                words[j+1] = temp;
            }
            else if(words[j].Length == words[j+1].Length)
            {
                for (int k = 0; k < words[j].Length; k++)
                {
                    if(words[j][k] > words[j+1][k])
                    {
                        temp = words[j];
                        words[j] = words[j+1];
                        words[j+1] = temp;
                        break;
                    }
                    else if(words[j][k] < words[j+1][k])
                        break;
                }
            }
        }
    }
    return words;
}

void ShowWords(string[] words)
{
    for (int i = 0; i < words.Length; i++)
        Console.Write(words[i] + " ");
    Console.WriteLine();
}
StringArraySort(names);
ShowWords(names);
*/

//про тернарные операторы
//еси b чётное, то значение b запишется в a,
//а еси нет, то в a запишется ноль
/*
int a = 5, b = 10;

a = (b % 2 == 0) ? b : 0;//в скобках булевая переменная(условие), 
//после знака вопроса идёт значение, которое записывается в переменную,
//если первый аргумент true, а после двоеточия значение, которое 
//запишется, если false
Console.WriteLine(a);
*/

/*
//перевод в привычную конструкцию с иф:

if(b % 2 == 0)
    a = b;
else
    a = 0;
*/