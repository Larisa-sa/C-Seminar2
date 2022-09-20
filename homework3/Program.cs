// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введи цифру, обозначающую день недели: ");
int dayNumber = int.Parse(Console.ReadLine());
if (dayNumber == 6 || dayNumber == 7)
{
  Console.WriteLine(dayNumber + " Это выходной? " + " -> " + "да");
}
else if (dayNumber < 1 || dayNumber > 7)
{
  Console.WriteLine("Дня недели с такой цифрой не существует");
}
else
{
Console.WriteLine(dayNumber + " Это выходной? " + " -> " + "нет");
}




