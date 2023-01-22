/* Задача 1: Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.
456 -> 5
782 -> 8
918 -> 1 */
int InputStringToInt(string message)
{
    Console.WriteLine(message);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}
int number = InputStringToInt("Введите 3-значное число");
if(number<0) number=-number;
int FindPenaltDigit(int a)
{
    int b = a / 10;
    int penalt = b % 10;
    return penalt;
}
/*А ещё можно было вот так:
int penalt=a%100/10;
return penalt
}
Кстати, как лучше для производительности?*/
if (number < 100 || number > 999)
{
    System.Console.WriteLine($"число {number} - не трёхзначное"); /*наверно, для улучшения 
    производительности это отсечение лучше было производить в начале решения задачи? */
}
else
{
    System.Console.WriteLine($"Вторая цифра числа {number} равна {FindPenaltDigit(number)}");
}