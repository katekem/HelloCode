// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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

// // Код
int[] myArray = CreateRandomArray(8, -10, 11);
Console.WriteLine(String.Join(",",myArray));

for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = -myArray[i];
}
Console.WriteLine(String.Join(",",myArray));


