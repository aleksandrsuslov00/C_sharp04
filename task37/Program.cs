// Задача 37. 

int[] Array = {6, 7, 3, 6};
printArray(Array);
int[] prodArray = productOfPairs(Array);
printArray(prodArray);


void printArray (int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(arrayToPrint[i] + ", "); // добавляем запятую между элементами до конца массива
        }
        else Console.WriteLine(arrayToPrint[i] + "]");
    }
}

int[] productOfPairs(int[] array)
{
    int size;
    if (array.Length % 2 == 0)
        size = array.Length / 2;
    else
        size = array.Length / 2 + 1;

    int[] productArray = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        productArray[i] = array[i] * array[array.Length - 1 - i];
    }
    if (size % 2 == 1)
    {
        productArray[size - 1] = array[array.Length / 2];
    }
    return productArray;
}


