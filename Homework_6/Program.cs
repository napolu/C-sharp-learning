/*
Задача 41: 
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Input " + i + " element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void PositiveCounter(int[] array)
{
    int positCount = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        positCount += 1;
    }
    Console.WriteLine("Positive numbers: " + positCount);
}

int[] Numbers = CreateArray(5);
ShowArray(Numbers);
PositiveCounter(Numbers);

*/

/*
Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.

45 -> 101101
3 -> 11
2 -> 10
*/

/*
int Convert2Bin(int dec)
{
    int bin = 0;
    int rank = 1;
    int remainder = 0;

    if(dec < 0)
        Console.WriteLine("Input a positive number pls");
    else
        while(dec > 0)
        {
            remainder = dec%2;
            bin = bin + remainder*rank;
            rank = rank*10;
            dec = dec/2;
        }
        return bin;
}
Console.Write("Input a decimal number: ");
int decNumb = Convert.ToInt32(Console.ReadLine());
int str = Convert2Bin(decNumb);
Console.WriteLine("The binary is " + str);

*/

/*
Задача 43: Напишите программу, которая найдёт точку пересечения 
двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

/*
void CrossFinder(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double yA = Math.Round(k1 * x + b1, 2);
    double yB = Math.Round(k2 * x + b2, 2);
    


    if(yA == yB && k1 != k2)
        Console.WriteLine("Intersection point is (" + x + ", " + yA + ")");
    else
        Console.WriteLine("These lines are parallel or overlap");
}

Console.Write("Input b1 number: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k1 number: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2 number: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2 number: ");
double k2 = Convert.ToInt32(Console.ReadLine());

CrossFinder(b1, k1, b2, k2);

*/