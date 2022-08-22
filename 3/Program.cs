/*ДОП.ЗАДАЧА:
Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
string a = "";
while (number > 0)
{
    a = a + Convert.ToString(number % 2);
    number = number / 2;
}
int len = a.Length;
string [] arr = new string [len];
for (int i = 0; i < len; i++)
{
    arr [len-1-i] = a[i].ToString();
}
Console.WriteLine($"В двоичной системе {String.Join("", arr)}");

