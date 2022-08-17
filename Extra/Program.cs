Console.Clear();

// If - else конструкция

string mes1 = "", mes2 = "";
Console.WriteLine("Введите целое число");
int n = int.Parse(Console.ReadLine());

if(n>=0) mes1 = "положительное";
else mes1 = "отрицательное";
if(n%2 == 0) mes2 = "четное";
else mes2 = "нечетное";

Console.WriteLine("Число {0}, {1}, {2}", n, mes1, mes2);
Console.ReadKey();


