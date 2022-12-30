// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число от 1 до 7: ");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

switch (number) {
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
    case 7:
        Console.WriteLine("Воскресенье");
        break;
    default:
        Console.WriteLine("Error!");
        break;                        
}

if (number == 6 | number == 7) {
    Console.WriteLine("Ура! Сегодня выходной :)");
} else if (number >= 1 && number <= 7) {
    Console.WriteLine("Сегодня рабочий день :(");
} else {
    Console.WriteLine("Введите правильное число");
}
