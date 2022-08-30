Console.Clear();

// If - else конструкция

// string mes1 = "", mes2 = "";
// Console.WriteLine("Введите целое число");
// int n = int.Parse(Console.ReadLine());

// if(n>=0) mes1 = "положительное";
// else mes1 = "отрицательное";
// if(n%2 == 0) mes2 = "четное";
// else mes2 = "нечетное";

// Console.WriteLine("Число {0}, {1}, {2}", n, mes1, mes2);
// Console.ReadKey();


// If - тернарный метод, рандом

// Random rnd = new Random();
// int n = rnd.Next(-40,40);
// string mes1 = (n >= 0) ? "положительное" : "отрицательное";
// string mes2 = (n%2 == 0) ? "четное" : "нечетное";
// Console.WriteLine("Число {0}, {1}, {2}", n, mes1, mes2);


// Switch конструкция

// string mes;
// Console.WriteLine("Введите день недели: Пн, Вт, Ср, Чт, Пт, Сб, Вс");
// string day = Console.ReadLine();
// switch (day)
// {
//     case "Сб": mes = "Иду в гости"; break;
//     case "Вс": mes = "Отдыхаю"; break;
//     default: mes = "Работаю"; break;
// }
// Console.WriteLine(mes);

// Задача на проверку логина и пароля

// Console.Write("Введите логин: ");
// string log = Console.ReadLine();
// string mes1 = "", mes2 = "";

// switch (log)
// {
//     case "login123": break;
//     default: mes1 = "Логин не зарегистрован"; break;
// }
// Console.WriteLine(mes1);

// if(mes1 == "")
// {
// Console.Write("Введите пароль: ");
// string pas = Console.ReadLine();

// switch (pas)
// {
//     case "qwerty123": mes2 = "Пароль верный"; break;
//     default: mes2 = "Пароль неверный"; break;
// }
// }
// Console.WriteLine(mes2);

// Другое решение

// string myLog = "qwerty", myPas = "asdf";
// string mes = "", mesYes = "Добро пожаловать!", mesNo = "Вход воспрещен!";
// Console.Write("Введите логин: ");
// string log = Console.ReadLine();
// if(log.Length < 6) mes = "Логин очень короткий\n" + mesNo;
// else if(log != myLog) mes = "Логин неверный\n" + mesNo;
// else
// {
//     Console.Write("Введите пароль: ");
//     string pas = Console.ReadLine();
//     mes = (pas == myPas) ? mesYes : mesNo;
// }
// Console.WriteLine(mes);

// Простейший калькулятор

double res = 0;
bool ok = true;
Console.WriteLine("Введите число A: ");
double.TryParse(Console.ReadLine(), out double A);
Console.WriteLine("Введите число B: ");
double.TryParse(Console.ReadLine(), out double B);
Console.WriteLine("Введите знак операции +-;/: ");
var op = Console.ReadLine();

// res = op switch
// {
//     "+" => A + B,
//     "-" => A - B,
//     "*" => A * B,
//     "/" => A / B,
//     _ => 0
// };

switch (op)
{
    case "+": res = A + B; break;
    case "-": res = A - B; break;
    case "*": res = A * B; break;
    case "/": res = A / B; break;
    default: ok = false; break;
}
if (ok)
{
    Console.WriteLine("{0} {1} {2} = {3}", A, op, B, res);
}
else
{
    Console.WriteLine("Недопустимая операция");
}