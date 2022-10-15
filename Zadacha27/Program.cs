// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число А");
int A = int.Parse(Console.ReadLine()!);

int result = 0;

while (A%10!=0 || A/10!=0)
{
    result += A%10;
    A = A/10;
}
Console.WriteLine();
Console.WriteLine(result);
