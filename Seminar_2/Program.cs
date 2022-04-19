/*
//Задача 1.
int ShowNumber(int n)
{
    int firstNum = n/10;
    int secondNum = n%10;

    Console.Write(n + " -> ");

    if(firstNum > secondNum)
    {
        return firstNum;
    }
    else
    {
        return secondNum;
    }
}

int num = new Random().Next(10, 99);
int a = ShowNumber(num);
Console.WriteLine(a);
*/

/*
//Задача 2.

void SomeNumbula()
{
    int num = new Random().Next(100, 999);
    int num1 = num/100;
    int num3 = num%10;
    int result = num1*10 + num3;

    Console.Write(num + " -> ");
    Console.Write(result);
    
}
SomeNumbula();
*/

/*
//Задача 3.

void DivisionB()
{
    Console.Write("Input first integer number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input second integer number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int remainder = num2%num1;


    if(num2%num1 == 0)
        Console.WriteLine("the second number is divisible by the first number");
    else
        Console.WriteLine("the remainder is " + remainder);
}
DivisionB();
*/

/*
//Задача 4.

void MultiPpl(int num)
{
    if(num%7 == 0 & num%23 == 0)
        Console.Write(num + " is multiple of 7 and 23");
    else
        Console.Write(num + "is NOT multiple of 7 and 23");
}

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
MultiPpl(num);

*/

/*
//Задача 5.

void SquareX(int num1, int num2)
{
    if(num1*num1 == num2)
        Console.WriteLine(num2 + " is a square of " + num1);
    else if(num2*num2 == num1)
        Console.WriteLine(num1 + " is a square of " + num2);
    else
        Console.WriteLine("These numbers are not squares of each other");
}
Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
SquareX(num1, num2);
*/