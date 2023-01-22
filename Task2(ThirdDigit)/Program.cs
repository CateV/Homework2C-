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
   while (number/1000 > 0)
{
    number = number/10;
}
int third = number%10;
System.Console.WriteLine($"третья цифра - {third}");
/*когда я последнюю строчку писала вот так:
System.Console.WriteLine($"Третья цифра числа {number} - {third}");
и при этом:
1)в dotnet run писала отрицательное число (к примеру, -345),
текст выводился почему-то "Третья цифра числа 345 - 5".
Почему выводил не "-345"? Как этого добиться? В чём ошибка?
2)в dotnet run писала чуть более длинное число (к примеру, 56779),
текст выводился "Третья цифра числа 567 - 5". Я понимаю, что он брал последнее значение 
number, а именно из     number = number/10. Но не понимаю, как сделать так, чтобы брал
то число, которое вводил пользователь. Подскажите, пожалуйста! =)

*/
}
