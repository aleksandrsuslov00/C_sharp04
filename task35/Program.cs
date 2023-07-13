/*
Задайте одномерный массив их 123 случайных чисел. Найдите количество
элементов массива, значения которых лежат в отрезке [10, 99] - двузначные числа.
Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123.
[5, 18, 213, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
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

int FillNumberArray (int[] randomArray, int start, int end)
{
    int count = 0;
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (randomArray[i] >= start && randomArray[i] <= end) 
        // if ((randomArray[i]>9) && (randomArray[i]<100))
        {
            count = count + 1; // count++;
        }
    }
    return count;
}    

int[] myArray = getRandomArray (123, 1000);
printArray(myArray);

int result = FillNumberArray(myArray, 10, 99);
Console.WriteLine($"Количество двузначных чисел в масиве - {result} ");
