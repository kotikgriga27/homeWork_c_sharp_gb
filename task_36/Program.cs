// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

FillArrayRandomNumbers(array);

Console.Write("массив: ");
Console.WriteLine($"[{String.Join(", ", array)}]");

int sum = 0;
for (int z = 1; z < array.Length; z+=2)
    sum = sum + array[z];

Console.WriteLine($"всего {array.Length} чисел, сумма элементов на нечётных позициях равняется {sum}");

void FillArrayRandomNumbers(int[] array) {
    for(int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(1,100);
    }
}

