// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите 3 числа: ");

string numberStrFirst = Console.ReadLine(); // Вводим первое число
int numberFirst = int.Parse(numberStrFirst);

string numberStrSecond = Console.ReadLine(); // Вводим второе число
int numberSecond = int.Parse(numberStrSecond);

string numberStrFhird = Console.ReadLine(); // Вводим третье число
int numberFhird = int.Parse(numberStrFhird);

int max = numberFirst;
if (max < numberSecond) {
    max = numberSecond;
}
if (max < numberFhird) {
    max = numberFhird;
}

Console.WriteLine("Наибольшее из введённых чисел: " + max);


