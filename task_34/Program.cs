// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

FillArrayRandomNumbers(array);

Console.Write("массив: ");
Console.WriteLine($"[{String.Join(", ", array)}]");

int count = 0;
for (int z = 0; z < array.Length; z++) {
    if (array[z] % 2 == 0) {
        count++;
    }    
}        

Console.WriteLine($"всего {array.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] array) {
    for(int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(100,1000);
    }
}

