// Напишите программу, которая на вход принимает 3 числа и проверяет,
// может ли существовать треугольник со сторонами такой длины
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон

//Обычное решение
// Console.Clear();
// Console.Write("Введите 1-ую длину стороны треугольника: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите 2-ую длину стороны треугольника: ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Введите 3-ую длину стороны треугольника: ");
// int c = int.Parse(Console.ReadLine());
// if (a + b < c && a + c < b && b + c < a)
// {
//     Console.WriteLine("Треугольника с такими сторонами быть не может");
// }
// else
// {
//     Console.WriteLine("Треугольник с такими сторонами может быть");
// }

//Через массивы - мое решение
// int[] triangle = new int[3]{a, b, c};
// Console.WriteLine(String.Join(" ", triangle));
// if(triangle[0] + triangle[1] < triangle[2] && triangle[1] + triangle[2] < triangle[0]
// && triangle[0] + triangle[2] < triangle[1] )
// {
//     Console.WriteLine("Треугольника с такими сторонами быть не может");
// }
// else
// {
//     Console.WriteLine("Треугольник с такими сторонами может быть");
// }


// Новое решение через массивы
Сonsole.Clear();
Console.Write("Введите стороны треугольника через пробел: ");

string[] st = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

if(IsTriangle(int.Parse(st[0]),int.Parse(st[1]),int.Parse(st[2])))
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}



bool IsTriangle(int a,int b,int c)
{
return (((a+b)>c)&&((a+c)>b)&&((b+c)>a));
}