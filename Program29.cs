// // Задача 29: Введите 8 чисел. Поместите в массив и распечатайте.
int[] CreateArray(int size)
{
    int[] array = new int[size];
    string[] text = Console.ReadLine().Split(" ");
    for (int i = 0; i < text.Length; i++)
    {
         array[i] = 0;
         array[i] = int.Parse(text[i]);

    }
    return array;
}
void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(",", array)}]");
}
Console.WriteLine("Введите 8 чисел");
PrintArray(CreateArray(8));
