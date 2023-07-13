/*
Задайте массив. Напишите программу, определяющую, присутствует ли заданное число в массиве.

4; массив [0,1,2,3] -> no
-3; массив [0,1,-2,-3] -> yes
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
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] randomArray = getRandomArray(5, 8);
printArray(randomArray);

bool IsNumberInArray(int[] randomArray, int target)
{
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (randomArray[i] == target)
        return true;
    }
    return false;
}

if (IsNumberInArray(randomArray, number))
{
    Console.WriteLine("Да");
}
else Console.WriteLine("Нет");




