// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int  N = Convert.ToInt32(Console.ReadLine());
if (N > 1)
{
    int count = 2;
    while (count <= N)
    {
        Console.WriteLine(count);
        count+=2;
    }
}
else
{
    Console.WriteLine("Некорректно введенное значение");
}