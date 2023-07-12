/*

Напишите цикл, который принимает на вход два числа (A и B)
и возводит число А в натуральную степень числа B

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.Write("Введите число A: ");
int num_A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int num_B = Convert.ToInt32(Console.ReadLine());

int Base (int num_A, int num_B)
{
    int result = 1;
    for (int i = 1; i <= num_B; i++)
    {
        result = result * num_A;
    }
    return result;
}
int exponentiation = Base(num_A, num_B);
Console.WriteLine($"{num_A} в степени {num_B} = {exponentiation}");
