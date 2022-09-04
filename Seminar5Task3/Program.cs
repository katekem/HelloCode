// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();
// Метод создания рандомного массива
int[] CreateRandomArray(int N, int start, int end)
{
    int[] array = new int[N];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}
// Задаем массив
int[] myArray = CreateRandomArray(123,-100,200);
Console.WriteLine(String.Join(",", myArray));
// Код
int count = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] >= 10 && myArray[i] <= 99)
    {
        count ++;
    }
}
Console.WriteLine($"Количество элементов, входящих в диапазон: {count}");
