/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/

Console.Write("сколько чисел будем вводить? ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
int result = 0;
for (int i = 0; i < M; i++)
{
    Console.Write($"{i+1}. введите число ");
    array [i] = Convert.ToInt32(Console.ReadLine());
    if (array [i] > 0) result ++;
}
Console.WriteLine($"Введено чисел больше нуля - {result}");
