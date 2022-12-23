/* Лекция 2.
   Задание 2: Найти максимальное число из 9 с исползованием массива. */

int[] numbers = new int[9]{4, 7, 1, -4, 31, 8, 31, 2, 0};

// Нахождение максимального числа из трёх
int Max(int number1, int number2, int number3) {
    int max_number = number1;
    if (number2 > max_number) max_number = number2;
    if (number3 > max_number) max_number = number3;
    return max_number;
}

int max = Max(
    Max(numbers[0], numbers[1], numbers[2]),
    Max(numbers[3], numbers[4], numbers[5]),
    Max(numbers[6], numbers[7], numbers[8])
);

Console.WriteLine($"max = {max}");