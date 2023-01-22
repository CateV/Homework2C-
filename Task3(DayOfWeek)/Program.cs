/* Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да 
7 -> да 
1 -> нет */
int InputStringToInt(string message)
{
    Console.WriteLine(message);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}
int dayNumber = InputStringToInt("Введите число от 1 до 7");
string[] weekDay = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
int index = dayNumber - 1;
if (dayNumber >0 && dayNumber <=7)
{    string status;
    if (dayNumber > 5)
        status = "выходной день";
    else
        status = "не выходной день";
   System.Console.WriteLine(weekDay[index] + "-" + status);
}
else 
{
       System.Console.WriteLine("нет такого дня недели");
}
//*стоит ли здесь создавать функцию DayOff, если можно решить намного проще?
/*пробовала писать: 
if (dayNumber = 6 || dayNumber = 7)...
получила ошибку:
"Оператор "||" невозможно применить к операнду  
типа "int" и "int""
Как это понимать? Неужели правда невозможно использовать с int и int??? */
