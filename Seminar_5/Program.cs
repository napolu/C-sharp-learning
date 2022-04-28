/*Задача 1

int[] ChangeNums(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] *= (-1);
    return array;
}

*/

//Задача 2
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

string LookFor(int[] array, int look)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == look)
        {
            return "Yes";
        }
    }
    return "No";
}

Console.WriteLine(LookFor({1,2,3,4,5}, 6));
//надо потом отдельно ввести массив
*/

//Задача 3.
/* создать одномерный массив из 15 случ чисел,
найти кол-во элементов в отрезке от 10 до 99 */


int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
        Console.Write(array[i] + " ");
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int NumberCount(int[] array)
{int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <=99)
            counter++;  
    }
    return counter;
}
/*
int[] MyArray = CreateRandomArray(15, 0, 1000);
ShowArray(MyArray);
NumberCount(MyArray);
*/

//Задача 4. Одномерный массив, 
//потом попарное произведение элементов с конца и начала в новый массив

int[] NewMagicArray(int[] array)
{
    int newSize = array.Length / 2;//размер нового массива
    int[] newArray = new int[newSize];//объявили новый массив

    for (int i = 0, j = array.Length - 1; i < newSize; i++,j--)
    {
        newArray[i] = array[i] * array[j];
    }

    return newArray;
}

int[] arrgh = CreateRandomArray(7, 1, 9);
int[] newArrgh = NewMagicArray(arrgh);
Console.WriteLine();
ShowArray(newArrgh);
