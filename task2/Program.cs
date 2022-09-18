// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
// 456 => 46
// 782 => 72
// 918 => 98

Console.Clear();
int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int a1 = num/100; // первое число 4
Console.WriteLine(a1);
int a2 = num/10; // два последних числа 45
Console.WriteLine(a2);
int a3 = num - (a2 * 10); //  последнее число 
Console.WriteLine(a3);
Console.WriteLine($"{num} => {a1}{a3}");

// int num = new Random().Next(100, 1000);        
// int a1 = num % 10;                               687 % 10 = 7
// int a2 = num/100;                                687 / 100 = 6
// Console.WriteLine($"{num} -> {a2 *10 + a1}");    687 -> 6*10+7 = 67