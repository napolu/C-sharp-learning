/*
//Задача 10.
 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1


void Midian(int num)
{
    int mid = (num/10) % 10;
    Console.WriteLine(num + " -> " + mid);
}
Console.Write("Input any integer number from 100 to 999: ");
int num = Convert.ToInt32(Console.ReadLine());
Midian(num);



//Задача 13.
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6


void Third(int num)
{
    int current = num;
    if(current < 99)
        Console.WriteLine("there's no third number");
    else
    {
        while(current >= 1000)
                current = current/10;
        if(current < 1000)
        {
            int result = current%10;
            Console.WriteLine(num + " -> " + result);
        }
    }
}    
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
Third(num);



//Задача 15.
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет


void Weekend(int day)
{
    if(day > 0 && day < 6)
        Console.WriteLine("NO, this isn't a weekend yet");
    else if(day >=6 && day < 8)
        Console.WriteLine("YES, a weekend, finally");
    else
        Console.WriteLine("nonexistent weekday");    
}
Console.Write("Input integer number from 1 to 7: ");
int day = Convert.ToInt32(Console.ReadLine());
Weekend(day);

*/