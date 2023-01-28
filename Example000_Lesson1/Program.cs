/*Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).

Например:
4 -> 16
-3 -> 9
-7 -> 49
*/

Console.WriteLine("Введите число:");

string numberStr = Console.ReadLine() ??"";
int number = int.Parse(numberStr);
int result = number * number;

Console.WriteLine($"квадрта числа {number} = {result}");