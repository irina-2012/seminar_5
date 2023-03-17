// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] Array()
{
    Random rand = new Random();
    int[] mas = new int[5];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = rand.Next(-10, 10);
    }
    return mas;
}

int Sum (int[] mas)
{
    int sum = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (i % 2 != 00)
        {
            sum = sum + mas[i];
        }
    } return sum;
}

int[] mas = Array();
Console.WriteLine($"[{String.Join(", ", mas)}]");
Console.WriteLine($"сумма элементов стоящих на нечетной позиции = {Sum(mas)}");