﻿// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числп
// 78 => 8
// 12 => 2
// 85 => 8
Console.Clear();
int num = new Random().Next(10, 100); // для случайного числа. Вторую цифру не включают, поэтому пишем +1
// Надо разделить число на цифры. У нас будет в нашем отрезке двузначное число, значит будет вводить цифру а1 и а2
int a1 = num/10; // делим нацело на 10, чтобы отсечь второе число 75/10=7 остается
int a2 = num % 10; // целочисленное деление. Покажет вторую цифру. Остаток
int max = a1;
if (max < a2)
{
    max = a2;
}
Console.WriteLine($"Рандомное число {num}");
Console.WriteLine($"Максимальная цифра в числе {num} -> {max}");
// $ интерполяция. Так можно вывести вместе и слова и переменные (не просто буквы)
