// ЗАДАЧА 2, условие:
// Напишите программу, которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее.

// НАЧЛО КОДА ЗАДАЧИ 2
/*
Console.Clear();
Console.Write("введите первое число -> ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите второе число -> ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.Write("бОльшее из двух -> " + num1 + ", а меньшее -> " + num2);
}
else
{
    Console.Write("бОльшее из двух -> " + num2 + ", а меньшее -> " + num1);
}

*/
// КОНЕЦ КОДА ЗАДАЧИ 2

// ЗАДАЧА 4, условие:
// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

// НАЧЛО КОДА ЗАДАЧИ 4

Console.Clear();
Console.Write("введите первое число -> ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите второе число -> ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите третье число -> ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;


if (num2 > max && num2 > num3)
{
    max = num2;
}
else
{
    if (num3 > max)
    {
        max = num3;
    }
}
Console.Write("бОльшее из трёх -> " + max);
// КОНЕЦ КОДА ЗАДАЧИ 4