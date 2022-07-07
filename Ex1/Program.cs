/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
Console.Clear();
void CreateArray(int[] array)
{
    int len = array.Length;
    for (int index = 0; index < len; index++)
    {
        array[index] = new Random().Next(100, 999);
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
int count = 0;
CreateArray(mass);
for (int i = 0; i < mass.Length; i++)
{
    int ch = mass[i] % 2;
    if (ch == 0) count++;
}
PrintArray(mass);
System.Console.WriteLine($" Количество четных чисел в массиве = {count}");