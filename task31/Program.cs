/*
Задайте массив из 12 элементов, 
заполненный случайными числами из промежутка [-9,9].
Найдите сумму отрицательных и положительных элементов.

[3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных равна 29,
сумма отрицательных равна -20.
*/

//метод создания массива
int[] getRandomArray(int lenght, int deviation)
{
    int[] result = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        result[i] = new Random().Next(-deviation, deviation + 1);
    }
    return result;
}

//метод для пустого массива для заполнения верхним методом
void printArray (int[] arrayToPrint)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("[");
    for(int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(", "); // добавляем запятую между элементами до конца массива
        }
    }
    Console.WriteLine("]");
    Console.WriteLine("===========================");
    Console.ForegroundColor = ConsoleColor.White;
}

int sumElementsOfArray(int [] arrayToCalculate, int multiply)
{
    int result = 0;
    for (int i = 0; i < arrayToCalculate.Length; i++)
    {
        if (arrayToCalculate[i] * multiply > 0)
        {
            result += arrayToCalculate[i];
        } 
    }
    return result;
} 

int[] randomArray = getRandomArray(12, 9);
printArray(randomArray);
Console.WriteLine();

int negativeSumOfArray = sumElementsOfArray(randomArray, -1);
int positiveSumOfArray = sumElementsOfArray(randomArray, 1);
Console.WriteLine($"Сумма положительных чисел в массиве равна {positiveSumOfArray}");
Console.WriteLine($"Сумма отрицательных чисел в массиве равна {negativeSumOfArray}");
