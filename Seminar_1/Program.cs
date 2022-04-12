/*
//Задача 1.

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine()); 
int result = num * num;
Console.WriteLine("Result is " + result);


// Задача 2.

Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2)
    Console.WriteLine("First number is a quad of second number");
else
    Console.WriteLine("First number is not a quad of second number");


//Задача 3.

Console.Write("Input number of weekday: ");
int day = Convert.ToInt32(Console.ReadLine());

if(day > 7 || day <1)
{
    Console.WriteLine("Incorrect number of day!");
}
else
{
    if(day == 1)
        Console.WriteLine("It's Monday");
    if(day == 2)
        Console.WriteLine("It's Tuesday");

     //etc   
}

//Задача 4.

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current;

if(num < 0)
{
    current = num;
    num = num * (-1);
}
else
{
    current = -1 * num;
}

while(current <= num)
{
   Console.Write(current + " ");
   current++;
}


//Задача 5.

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 100 || num > 999)
    Console.WriteLine("Ошиб очка");
else
{
    int a = num % 10;
    Console.WriteLine("Resulted number is " + a);
}

*/