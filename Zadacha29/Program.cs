// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];
Random Znach = new Random();
int index = 0;

while (index<array.Length)
{
    array[index]=Znach.Next(1,101);
    Console.Write($"{array[index]} ");
    index++;
}
