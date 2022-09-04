// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
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
// Задаем массив
int[] myArray = CreateRandomArray(6, 0, 10);
Console.WriteLine(String.Join(",",myArray));
// Код
int result = 0;
int a = myArray.Length -1;
for (int i = 0; i < myArray.Length/2; i++)
{
    result = myArray[i]*myArray[a];
    a -=1;
    Console.Write($"[{String.Join(",",result)}]");
}
if(myArray.Length%2 != 0)
{
Console.Write($"[{String.Join(",", myArray[myArray.Length/2])}]");
}
Console.WriteLine();
