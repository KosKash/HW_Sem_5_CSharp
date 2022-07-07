/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
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
int sum = 0;
for (int i = 1; i < mass.Length;)
{
    sum+=mass[i];
    i = i+2;
}
PrintArray(mass);
System.Console.WriteLine($" Сумма эл. массива стоящих на нечетной позиции = {sum}");