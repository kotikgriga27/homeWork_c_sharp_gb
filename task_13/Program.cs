// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);
int count = number.ToString().Length;

if (count >= 3) {
    int step = 1;
    int i = count;
    while (i > 3) {
        step = step * 10;
        i = i - 1;
    }

    int result = (number / step) % 10;
    Console.WriteLine(result);
} else {
    Console.WriteLine("Третьей цифры нет");
}
