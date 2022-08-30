//Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.

// int GetSumNums(int number)
// {
//     int sum = 0;
//     for (int i = 1; i <= Math.Abs(number); i++)
//     {
//         sum += i;
//     } 
//     return sum;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"Cумма цифр от 1 до введенного числа: {GetSumNums(num)}");

// / Написать программу, которая выводить произведение всех числе от 1 до N

// Console.Clear();

// int GetSumNums(int number)
// {
//     int sum = 1;
//     for (int i = 1; i <= Math.Abs(number); i++)
//     {
//         sum = sum * i;
//     } 
//     return sum;
// }

// /Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// int[] array1 = new int[8];

// Random rnd = new Random();
// Console.Write ("Случайный массив из 8 элементов в диапазоне [0,1] - ");
// for ( int i = 0; i < 8; i++)
// {
//     array1[i] = rnd.Next(0,2);
//     Console.Write (array1[i] + " ");
// }

// long fact(long num)
// {

//     if (num == 1)
//     {
//         return num;
//     }
//     else
//     {
//         return num * fact(num - 1);
//     }
// }

// Console.WriteLine("Введите число N");
// long inputNumber = Convert.ToInt64(Console.ReadLine());
// Console.WriteLine("Факториал числа " + fact(inputNumber));


// //
// Console.Write("Введите число - ");

// double N = Convert.ToDouble(Console.ReadLine());

// double digits_num = Math.Floor(Math.Log10(N) + 1);
// Console.WriteLine ("Количество цифр во введенном числе - " + digits_num);
