// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Random rand = new Random();
double[] Mass()
{
    double[] mas = new double[5];
    for (int i = 0; i < mas.Length; i++)
    {
        double el = mas[i] = Convert.ToDouble(rand.Next(-1000, 1000) / 10.0);
    }
    return mas;
}

double[] MaxMin(double[] mas)
{
    double max = mas[0];
    double min = mas[0];
    double[] result = new double[2];
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] > max)
        {
            max = mas[i];
        }
        else if (mas[i] < min)
        { min = mas[i]; }
    }
    result[0] = max;
    result[1] = min;
    return result;
}

double Razn(double[] mas)
{
    double r = mas[0] - mas[1];
    return r;
}

double[] array = Mass();
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Разница между максимальным {MaxMin(array)[0]} и минимальным {MaxMin(array)[1]} => {Razn(MaxMin(array))}");
