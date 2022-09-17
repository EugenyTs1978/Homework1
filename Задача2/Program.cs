// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"max = {a}, min = {b}");
}    
else if (a < b)
{
    Console.WriteLine($"max = {b}, min = {a}");
}
else 
{
    Console.WriteLine($"Числа равны: max = min = {a}");
}