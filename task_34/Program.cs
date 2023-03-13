// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.Clear();
int[] mas = new int [5];
int count = 0;
Random rand = new Random();

for (int i = 0; i < mas.Length; i++)
{
    Console.Write($"{mas[i]= rand.Next(100,1000)} ");
    if (mas[i]% 2 == 00)
    {
        count ++;
    }
} Console.Write($"-> {count}");



