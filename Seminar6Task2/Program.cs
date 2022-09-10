// Напишите программу, которая будет преобразовывать десятичное число в двоичное
// 45 -> 101101
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int i = 0;
int[] res = new int[10];
while (num / 2 != 0)
{
    res[i] = num % 2;
    num = num / 2;
    i++;
}
Console.WriteLine(String.Join(" ", res));

    // Степан: // Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.WriteLine("Введите число N");
// int N = Convert.ToInt32(Console.ReadLine());
// int x = 1;
// while (N > 0)
// {
// if (N % 2 == 0)
// {
// x++;
// N = N / 2;
// }
// else
// {
// x++;
// N = N / 2;
// }
// }

// int [] array = new int[x];
// int I = 0;
// while (N > 0)
// {
// if (N % 2 == 0)
// {
// array[I] = 0;
// I++;
// N = N / 2;
// }
// else
// {
// array[I] = 1;
// I++;
// N = N / 2;156
// }
// }

// Console.Write(array);

//Alexandra Goncharova (she/her): string FuncTo2(int chislo)
{
if (chislo == 1)
return "1";
else
return FuncTo2(chislo / 2) + (chislo % 2);
}
