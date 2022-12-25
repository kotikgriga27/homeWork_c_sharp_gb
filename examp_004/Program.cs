// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int i = 1;

Console.WriteLine("Введите число: ");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

Console.WriteLine("Чётные числа от 1 до " + number);
while (i <= number) {
    if (i % 2 == 0) {
        Console.Write(i + ", ");
    }
    i++;
}

