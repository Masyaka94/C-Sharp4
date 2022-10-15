/* Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.*/

Console.WriteLine("Введите число А");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine()!);

int result = 1;

for (int i = 1; i<=B; i++)
{
result *= A;
}

Console.WriteLine();
Console.WriteLine($"{result} - число {A} в степени {B}");