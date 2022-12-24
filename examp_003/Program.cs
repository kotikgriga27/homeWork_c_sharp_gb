// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число: ");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

if (number % 2 == 0) {
    Console.WriteLine("Число " + number + " является чётным");
} else {
    Console.WriteLine("Число " + number + " является нечётным");
}

