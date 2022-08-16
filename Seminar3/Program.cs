Console.Clear();
Console.WriteLine("Введите координаты x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y: ");
int y = Convert.ToInt32(Console.ReadLine());
if(x > 0 && y > 0)
{
    Console.WriteLine("Первая четверть");
}
else if(x < 0 && y > 0)
{
    Console.WriteLine("Вторая четверть");
}
else if(x < 0 && y < 0)
{
    Console.WriteLine("Третья четверть");
}
else if(x > 0 && y < 0)
{
    Console.WriteLine("Четвертая четверть");
}
else{
    Console.WriteLine("Определить четверть невозможно");
}


Console.Write("Введите координаты точки X: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки Y: ");
int y = int.Parse(Console.ReadLine()!);
string mes = "";
if (x == 0)
Console.Write("введите отличное от 0");
if (y == 0)
Console.Write("введите отличное от 0");
switch (x, y)
{
case (>0, >0): mes = "1"; break;
case (>0, <0): mes = "4"; break;
case (<0, >0): mes = "2"; break;
case (<0, <0): mes = "3"; break;
}
Console.WriteLine(mes);


Console.Write("Введите координаты точки X: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки Y: ");
int y = int.Parse(Console.ReadLine()!);
string mes = "";

switch (x, y)
{
case (>0, >0): mes = "1"; break;
case (>0, <0): mes = "4"; break;
case (<0, >0): mes = "2"; break;
case (<0, <0): mes = "3"; break;
default : mes = "введите отличное от 0"; break;
}
Console.WriteLine(mes);

//Нахождение четверти через функцию, через void надо писать вместо return
// Console.Writeline - в теле функции
int printQuarter(int a, int b)
{
if (a>0 && b>0)
{
return 1;
}
else if (a<0 && b>0)
{
return 2;
}
else if (a<0 && b<0)
{
return 3;
}
else if (a>0 && b<0)
{
return 4;
}
else
{
return 0;
}
}


Console.WriteLine ("Введите координаты x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координаты y");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Номер четверти - {printQuarter(x, y)}");

//Через void
void printQuarter(int a, int b)
{
if (a > 0 && b > 0)
{
Console.WriteLine("1");
}
else if (a < 0 && b > 0)
{
Console.WriteLine("2");
}
else if (a < 0 && b < 0)
{
Console.WriteLine("3");
}
else if (a > 0 && b < 0)
{
Console.WriteLine("4");
}
else
{
Console.WriteLine("ERROR");
}
}

Console.WriteLine("Введите координату х");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y");
int y = Convert.ToInt32(Console.ReadLine());
printQuarter(x, y);

// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Write("Введите номер четверти: ");
int quarter=int.Parse(Console.ReadLine());

switch (quarter)
{
case 1:
{
Console.WriteLine("x>0 y>0");
break;
}
case 2:
{
Console.WriteLine("x<0 y>0");
break;
}
case 3:
{
Console.WriteLine("x<0 y<0");
break;
}
case 4:
{
Console.WriteLine("x>0 y<0");
break;
}

default:
{
Console.WriteLine("Введена неправильная четверть");
break;
}
}

//Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

Console.Clear();
Console.Write("Введите X1: ");
int x1=int.Parse(Console.ReadLine());
Console.Write("Введите Y1: ");
int y1=int.Parse(Console.ReadLine());
Console.Write("Введите X2: ");
int x2=int.Parse(Console.ReadLine());
Console.Write("Введите Y2: ");
int y2=int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2));

Console.WriteLine($"d={d:f2}");