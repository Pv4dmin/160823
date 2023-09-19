// Задача 65: Задайте значения M и N. Напишите программу, которая найдет сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int InputNum(string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()!);
}

int PrintNumbers(int start, int end)
{
if (start > end) return 0;
return start + PrintNumbers(++start, end);

}
int first = InputNum("введите число M: ");
int second = InputNum("введите число N: ");
int series = PrintNumbers(first, second);
Console.WriteLine(series);