// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
string numberStrA = Console.ReadLine();
int numberA = int.Parse(numberStrA);

Console.WriteLine("Введите второе число: ");
string numberStrB = Console.ReadLine();
int numberB = int.Parse(numberStrB);

if (numberA > numberB) {
    Console.WriteLine("Первое число " + numberA + " больше чем второе " + numberB);
} else {
    Console.WriteLine("Второе число " + numberB + " больше чем первое " + numberA);
}

