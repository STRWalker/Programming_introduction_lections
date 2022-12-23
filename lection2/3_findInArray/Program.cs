/* Лекция 2.
   Задание 3: Найти первый элемент со значением find в массиве. */

int[] numbers = {1, 12, 31, 4, 15, 16, 17, 18};
int find = 4;

int length = numbers.Length;
int index = 0;
while (index < length) {
    if (numbers[index] == find) {
        Console.WriteLine($"find index = {index}");
        break;
    }
    index++;
}