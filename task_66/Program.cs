﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите начальное число M: ");
int numberM = int.Parse(Console.ReadLine());

Console.Write("Введите начальное число N: ");
int numberN = int.Parse(Console.ReadLine());

//Метод нахождения суммы натуральных элементов в промежутке от M до N
void GapNumberSum (int numberM, int numberN, int sum) {
    if (numberM > numberN) {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N -> {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    GapNumberSum(numberM, numberN, sum);
}

GapNumberSum(numberM, numberN, 0);
