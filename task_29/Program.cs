// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Write("Введите числа: ");
int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
Console.WriteLine($"[{String.Join(", ", array)}]");






