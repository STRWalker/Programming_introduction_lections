/* Лекция 2.
   Задание 4: В случайном массиве чисел найти и вывести индекс первого значения find. */

void FillArray(int[] numbers) {
    int count = numbers.Length;
    int current = 0;
    while (current < count) {
        numbers[current] = new Random().Next(1, 10);
        current++;
    }
}

void PrintArray(int[] numbers) {
    int count = numbers.Length;
    int current = 0;
    while (current < count) {
        Console.Write(numbers[current] + " ");
        current++;
    }
    Console.WriteLine();
}

int IndexOf(int[] numbers, int find) {
    int count = numbers.Length;
    int current = 0;
    int find_position = -1;
    while (current < count) {
        if (numbers[current] == find) {
            find_position = current;
            break;
        }
        current++;
    }
    return find_position;
}

int[] array = new int[10];
int find = 4;

FillArray(array);
PrintArray(array);
int find_position = IndexOf(array, find);
Console.WriteLine($"find position = {find_position}");