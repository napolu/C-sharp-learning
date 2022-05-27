/*
Задача 66: 
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

/*
int RecursSum(int m, int n)
{
    if(m <= n)
        {
            return m + RecursSum(m+1, n);
        }
    else 
        return 0;                   
}

Console.Write("Input first number: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The sum of elements is: " + RecursSum(m,n));
*/

/*Задача 67: 
Напишите программу, которая будет принимать на вход число 
и возвращать сумму его цифр.

453 -> 12
45 -> 9
*/

//num%10 + (num/10)%10 + ((num/10)/10)%10
/*
int CypherSum(int num)
{
    if(num%10 > 0 || num/10 > 0)
        return num%10 + CypherSum(num/10);
    else return 0;
}

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("The sum of cyphers in this number is: " + CypherSum(num));
*/
