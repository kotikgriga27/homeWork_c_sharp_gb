// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = new double[size];

FillArrayRandomNumbers(array);

Console.Write("массив: ");
Console.WriteLine($"[{String.Join("; ", array)}]");

double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int z = 0; z < array.Length; z++) {
    if (array[z] > max) {
        max = array[z];
    }

    if (array[z] < min) {
        min = array[z];
    }
}

double distance = Math.Round((max - min), 1);

Console.WriteLine($"Всего {array.Length} чисел. Максимальное значение -> {max}, минимальное значение -> {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением -> {distance}");

void FillArrayRandomNumbers(double[] array) {
    for(int i = 0; i < array.Length; i++) {
        array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 10.0;
    }
}
