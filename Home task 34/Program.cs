/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] getRandomArray(int lenght, int deviation)
{
    int[] result = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        result[i] = new Random().Next(0, deviation + 1);
    }
    return result;
}

void printArray (int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(", "); // добавляем запятую между элементами до конца массива
        }
    }
    Console.WriteLine("]");
}

int[] array = getRandomArray(4, 999);

int evenNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int oddNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1)
        {
            count++;
        }
    }
    return count;
}

printArray(array);
int countEvenNumbers = evenNumbers(array);
int countOddNumbers = oddNumbers(array);
Console.WriteLine($"Количество чётных чисел в массиве: {countEvenNumbers} ");
Console.Write($"Количество нечётных чисел в массиве: {countOddNumbers} ");