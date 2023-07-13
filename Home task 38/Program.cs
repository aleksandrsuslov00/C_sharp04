/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/
void GetRandomArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}

void printArray(double[] arrayToPrint)
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


Console.WriteLine("Укажи размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
GetRandomArray(array);
printArray(array);

double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}

Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}. Разница между максимальным и минимальным значением элементов массива {max - min}");

