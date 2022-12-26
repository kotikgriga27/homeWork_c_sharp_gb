// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трёхзначное число: ");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);
int count = number.ToString().Length;

if (count == 3) {
    int result = ((number / 10) % 10);
     Console.WriteLine(result);
} else {
    Console.WriteLine("Вы ввели не трёхзначное число!");
}
