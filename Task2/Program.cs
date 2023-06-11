// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
void SummMN(int M, int N, int Summ) {
    if (M > N) {
    Console.WriteLine($"Сумма равна {Summ}.");
    return;
    }
    else {
        Summ += (M++);

    }
   SummMN(M, N, Summ);
}

Console.Write("Введите M (меньшее число): ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите M (большее число): ");
int N = Convert.ToInt32(Console.ReadLine());


if ((M < 0) | (N < 0)) {
    Console.WriteLine("Числа должны быть больше 0. Попробуйте еще раз");
}
else {
if ((M > N) | (M == N)) {
    Console.WriteLine("M должно быть меньше N. Попробуйте еще раз");
}
else {
SummMN(M, N, 0);
}
}


