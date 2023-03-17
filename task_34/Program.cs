// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] Array()
{
    Random rand = new Random();
    int[] mas = new int[10];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = rand.Next(100, 1000);
    }
    return mas;
}

int Number(int[] mas)
{
    int count = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] % 2 == 00)
        {
            count++;
        }
    }return count;
}

int [] mas = Array();
Console.WriteLine($"[{String.Join(", ", mas)}]");
Console.WriteLine($"Количество четных чисел в массиве = {Number(mas)}");

