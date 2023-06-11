// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void AllNumbers(int number) {
    if (number == 0) {
        return;
    }
    Console. Write($"{number} ");
    AllNumbers(number-1);
}

Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 1) {
    Console.WriteLine("Исходное число должно быть больше, либо равно 1. Пустой вывод");
}
else {
    AllNumbers(N);
}

