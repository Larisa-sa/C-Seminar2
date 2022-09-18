// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
Console.Clear();
Console.WriteLine("Введите первое число ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = int.Parse(Console.ReadLine());
int rest = number1 % number2;
if (number1 % number2 == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine($"не кратно, остаток {rest}");
}
