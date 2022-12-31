// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число:");
string numberStr = Console.ReadLine();
int len = numberStr.Length;

int flag = 1;
if (len == 5) {
    for (int i = 0; i <= len / 2 + 1; i++) {
        if (numberStr[i] != numberStr[len - i - 1]) {
            flag = 0;
            break;
        }
    }

    if (flag == 1) {
        Console.WriteLine("Число " + numberStr + " является палиндромом");
    } else {
        Console.WriteLine("Число " + numberStr + " НЕ является палиндромом");
    }

} else {
    Console.WriteLine("Error! Введите правильное число");
}
