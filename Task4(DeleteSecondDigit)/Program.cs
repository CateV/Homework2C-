/* Напишите программу, которая выводит случайное трёхзначное число 
и удаляет вторую цифру этого числа */
int number = new Random().Next(100,1000);
int withoutDozens = number - number%100 + number%10;
int hundredsToDozens = withoutDozens%10 + withoutDozens/10;
System.Console.WriteLine($"Было число {number}, стало число {hundredsToDozens}");