// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число от 1 до 7: ");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

if (number == 6 | number == 7) {
    Console.WriteLine("Ура! Сегодня выходной :)");
} else if (number >= 1 && number <= 7) {
    Console.WriteLine("Сегодня рабочий день :(");
} else {
    Console.WriteLine("Error! Введите правильное число");
}
