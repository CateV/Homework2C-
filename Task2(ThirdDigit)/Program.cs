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
    int n = number;
    int count = 0;
while (n/10 > 0)
{
    n = n/10;
    count++;
}
int multiple = number;
int devideBy10 = count - 2;
while (devideBy10>0)
{
    multiple = multiple/10;
    devideBy10=devideBy10-1;
}
int third = multiple%10;
/*наверно можно и так, но как степень пишется?   
int third = number/10 в степени devideBy10%10; */
System.Console.WriteLine($"Третья цифра числа {number} - {third}");
}