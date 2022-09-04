// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();
// // Скопировали метод создания рандомного массива
int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
// Задали массив и вывели его
int[] myArray = CreateRandomArray(8, -10, 20);
Console.WriteLine(String.Join(",", myArray));
// Код
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] == num)
    {
        count++;
    }
}
if (count > 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}




