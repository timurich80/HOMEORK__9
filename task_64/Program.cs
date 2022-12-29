/* Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> 2, 4
M = 4; N = 8 -> 4, 6, 8 */


Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());



NaturalToLow(n, m);
void NaturalToLow(int n, int m)
{
    if (m > n)
    {
        return;
    }
    else
    {
        NaturalToLow(n, m + 1);
        Console.Write(m + " ");
    }
}