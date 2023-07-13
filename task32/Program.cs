/*
Напишите программу замены элементов массива:
положительные элементы заменить на соответветствующие отрицательные и наоборот.
*/

int[] FillArray(int lenght, int deviation)
{
    int[] result = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        result[i] = new Random().Next(-deviation, deviation + 1);
    }
    printArray(result);
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

void NegToPos(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] *= -1;
    }
}
int[] numsArray = FillArray(15, 10);
NegToPos(numsArray);
printArray(numsArray);