/*
Задача 1: 
Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
/*
Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int current = 1;
for (int i = 0; i < num2; i++)
{
    current *= num1;
}
Console.WriteLine(num1 + " to the power of " + num2 + " equals " + current);
*/


/*
Задача 2: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

/*
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while(num%10 > 0 || num/10 > 0)
{
    sum += num%10;
    num /= 10;
}
Console.WriteLine("Sum of cyphers is: " + sum);
*/


/*
Задача 3: 
Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
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
    Console.Write("[");
        {
            int i = 0;
            
            while(i < array.Length)
            {
                Console.Write(array[i]);
                i++;
                if(i < array.Length)
                    Console.Write(", ");
            }
        }
            
    Console.Write("]");
}

int[] MyArray = CreateArray(8);
ShowArray(MyArray);

*/