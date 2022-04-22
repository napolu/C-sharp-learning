/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да


void PalindromeCheck(int num)
{
    if(num < 10000 || num >99999)
    Console.WriteLine("Incorrect number");

    else if(num/10000 == num%10 && (num%10000)/1000 == (num%100)/10)
    Console.WriteLine("YES, " + num + " is a palindrome");

    else
    Console.WriteLine("NO, " + num + " isn't a palindrome");
}
Console.Write("Input any integer number from 10000 to 99999: ");
int num = Convert.ToInt32(Console.ReadLine());
PalindromeCheck(num);



Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53


double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));
    distance = Math.Round(distance, 2);
    return distance;
}

Console.Write("Input Xa coordinate: ");
double xDot1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Ya coordinate: ");
double yDot1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Za coordinate: ");
double zDot1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Xb coordinate: ");
double xDot2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Yb coordinate: ");
double yDot2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Zb coordinate: ");
double zDot2 = Convert.ToInt32(Console.ReadLine());

double distance = FindDistance(xDot1, yDot1, zDot1, xDot2, yDot2, zDot2);
Console.Write("The distance between A and B is " + distance);



Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125


void Cube( int n)
{
    if(n > 0)
    {
        int current = 1;
        while(current <= n)
        {
            int result = current*current*current;
            Console.Write(result + " ");
            current++;
        }
    }
    else
    {
        int current = n;
        while(current <= 1)
        {
            int result = current*current*current;
            Console.Write(result + " ");
            current++;
        }
    }
}
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
Cube(num);

*/
