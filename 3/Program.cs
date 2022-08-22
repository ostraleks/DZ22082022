/*ДОП.ЗАДАЧА:
Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
string invnum = "";
while (number > 0)
{
    invnum = invnum + Convert.ToString(number % 2);
    number = number / 2;
}
int len = invnum.Length;
string [] binum = new string [len];
for (int i = 0; i < len; i++)
{
    binum [len-1-i] = invnum[i].ToString();
}
Console.WriteLine($"В двоичной системе {String.Join("", binum)}");

