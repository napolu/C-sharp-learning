//Methods

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1); 
    }
    return array;
}

double[] CreateDoubleArray()
{
    int size = 5;
    double[] array = new double[size];
    Random randNum = new Random();
    double number;

    for (int i = 0; i < size; i++)
    {
        number = randNum.NextDouble();
        array[i] = Math.Round(number,2);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void EvenCounter(int[] array)
{
    int evenCount = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0)
        evenCount=evenCount + 1;
    }
    Console.WriteLine("Even numbers in the array: " + evenCount);
}

void SumOddIndex(int[] array)
{
    int sumOdd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i%2 == 1)
            sumOdd += array[i];
    }
    Console.WriteLine("Sum of all elements with odd index is " + sumOdd);
}

void MinMax(double[] array)
{
    double maxNum = array[0];
    double minNum = array[0];
    
    for (int i = 0; i <array.Length; i++)
    {
        if(array[i] > maxNum)
            maxNum = array[i];
        else if(array[i] < minNum)
            minNum = array[i];
    }
double result = Math.Round(maxNum - minNum, 2);
Console.WriteLine("Maximum number is: " + maxNum + " and minimum number is: " + minNum);
Console.WriteLine("The difference between min and max numbers is: " + result);
}


/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

/*
int[] myArray = CreateRandomArray(4, 100, 999);
ShowArray(myArray);
EvenCounter(myArray);
*/


/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

/*
int[] myArray2 = CreateRandomArray(4, -100, 100);
ShowArray(myArray2);
SumOddIndex(myArray2);
*/


/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

[3 7 22 2 78] -> 76
*/

/*
double[] MyArray = CreateDoubleArray();
var arr = string.Join(" ", MyArray);
Console.WriteLine("Array: " + arr);
MinMax(MyArray);
*/