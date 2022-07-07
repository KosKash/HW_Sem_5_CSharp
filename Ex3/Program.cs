/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/
Console.Clear();
void CreateArray(int[] array)
{
    int len = array.Length;
    for (int index = 0; index < len; index++)
    {
        array[index] = new Random().Next(1, 100);
    }
}
void PrintArray(int[] arr)
{
    int count = arr.Length;
    System.Console.Write("[");
    System.Console.Write(arr[0]);
    for (int pos = 1; pos < count; pos++)
    {
        System.Console.Write($", {arr[pos]}");
    }
    System.Console.Write("]");

}

int[] mass = new int[6];
CreateArray(mass);

int Mx()
{
    int i = 0;
    int max = mass[i];
    while (i < mass.Length)
    {

        if (mass[i] > max) max = mass[i];
        i++;
    }
    return max;
}
int Mn()
{
    int i = 0;
    int min = mass[i];
    while (i < mass.Length)
    {

        if (mass[i] < min) min = mass[i];
        i++;
    }
    return min;
}

int mx1 = Mx();
int mn1 = Mn();

int res = mx1 - mn1;
PrintArray(mass);
System.Console.WriteLine($" Разность элементов макс и мин значения массива = {res}");