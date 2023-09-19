﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputNum(string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()!);
}

int AkkerNums(int num1, int num2)
{
if (num1 == 0) return num2 + 1;  
else if (num2 == 0) return AkkerNums(num1 - 1,1); 
else return AkkerNums(num1 - 1, AkkerNums(num1, num2 - 1));
}

int first = InputNum("введите число M: ");
int second = InputNum("введите число N: ");
int series = AkkerNums(first, second);
Console.WriteLine(series);