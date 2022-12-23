/* Лекция 2.
   Задание 1: Найти максимальное число из 9*/

int num1 = 4, num2 = 7, num3 = 1,
    num4 = -4, num5 = 31, num6 = 8,
    num7 = 31, num8 = 2, num9 = 0;

// Нахождение максимального числа из трёх
int Max(int number1, int number2, int number3) {
    int max_number = number1;
    if (number2 > max_number) max_number = number2;
    if (number3 > max_number) max_number = number3;
    return max_number;
}

int max = Max(
    Max(num1, num2, num3),
    Max(num4, num5, num6),
    Max(num7, num8, num9)
);

Console.WriteLine($"max = {max}");