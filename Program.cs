//Написать программу, которая принимает на вход два числа и проверяет, является ли первое число квадратом второго
Console.Clear();

Console.WriteLine("Введите число A: ");
Console.WriteLine("Введите число B: ");

int numberA = int.Parse(Console.ReadLine()!);
int numberB = int.Parse(Console.ReadLine()!);

if (numberA == numberB * numberB)
{Console.WriteLine("Да, первое число является квадратом второго числа");
}

else {
Console.WriteLine("Нет, первое число не является квадратом второго");
}
