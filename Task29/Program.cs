// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.

int[] arr = new int[8];
for (int i = 0; i <= arr.Length - 1; i++)
{
    Console.WriteLine("Введите число X");
    int X = Convert.ToInt32(Console.ReadLine());
    arr[i] = X;

}
Console.Write($"[ {string.Join(", ", arr)} ]");