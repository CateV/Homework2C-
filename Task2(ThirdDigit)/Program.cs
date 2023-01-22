/*Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
 что третьей цифры нет. Не использовать строки для расчета. */
int InputStringToInt(string message)
{
    Console.WriteLine(message);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}
int number = InputStringToInt("введите целое число");
if (number < 0) number = -number;
if (number < 100)
    System.Console.WriteLine($"в числе {number} третьей цифры нет");
else
{
    int last = number % 10;
    if (number / 1000 < 0) int trird = last;
    System.Console.WriteLine($"третья цифра числа {number} - {third}");
}