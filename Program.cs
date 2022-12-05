// Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write($"Введите число N ");
int N = int.Parse(Console.ReadLine()!);
double [] array = new double[N];
int index = 0;
while (index<N)
{
array[index] = Math.Pow(index+1,3);
Console.Write($" {array[index]} ");
index++;
}
