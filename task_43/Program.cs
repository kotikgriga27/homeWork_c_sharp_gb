//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями: 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double pointX;
double pointY;

Console.Write("Введите по очереди b1, k1, b2 и k2 одной строкой через пробел: ");
int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int a = arr [1]; // k1
int b = arr [3]; // k2
int c = arr [0]; // b1
int d = arr [2]; // b2

if (c == d) {
    if (a == b) {
        Console.WriteLine("Прямые совпадают");
    }    
}

if (a == b) {
    Console.WriteLine("Прямые параллельны");
} else {
    pointX = (double) (d-c)/(a-b);
    pointY = (double) a*(d-c)/(a-b) + c;
    Console.WriteLine("Координаты точки пересечения двух прямых:");
    Console.WriteLine($"Х: {pointX:0.00}");
    Console.WriteLine($"Y: {pointY:0.00}");
}