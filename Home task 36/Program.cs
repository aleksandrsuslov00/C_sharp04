/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


int[] getRandomArray(int lenght, int deviation)
{
    int[] result = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        result[i] = new Random().Next(-deviation, deviation + 1);
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

int[] array = getRandomArray(10, 99);
printArray(array);

int sumOddNumbers (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int sumOdd = sumOddNumbers(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {sumOdd}");
