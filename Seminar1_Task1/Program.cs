//Напишите программу, которая на вход принимает число и выдает его квадрат
//Console.Clear();
//Console.Write("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//int sqrt = number * number;
//Console.WriteLine("Число в квадрате: " + sqrt);

Console.Clear();
//Console.WriteLine("Input first number: ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Input second number: ");
//int num2 = Convert.ToInt32(Console.ReadLine());
//int square = num2 * num2;
//if(num1 == square)
//Console.WriteLine("First number is a square of second number");
//else
//{
//    Console.WriteLine("First number is not a square of second number");
//}

//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

Console.Write("Input number of the day: ");

int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 7)
{
Console.Write("Incorrect number");
}
else
{
if (day == 1)
{
Console.Write("Monday");
}
if (day == 2)
{
Console.Write("Tuesday");
}
}