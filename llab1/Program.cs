//Лабораторная работа №1
//Арифметические выражения
//Средний уровень. Вариант 6
//Console.WriteLine("Введите : i");
//double i = double.Parse(Console.ReadLine());
//Console.WriteLine("Введите:y");
//double y = double.Parse(Console.ReadLine());
//Console.WriteLine($"L={0.81 * (Math.Cos(i)) / (Math.Log(y) + Math.Pow(2 * i, 3))}");

//Лабораторная работа №1.2
//Программирование линейных алгоритмов
//Средний уровень. Вариант 6

Console.WriteLine("Введите:m");
double m = double.Parse(Console.ReadLine());
Console.WriteLine("Введите:x");
double x = double.Parse(Console.ReadLine());
double b = Math.Pow(x, 4) + Math.Pow(m, 2);
double a = Math.Sqrt(Math.Abs(x));
double y = Math.Sin(x) * Math.Sin(x) * (a + (Math.Tan(x) * Math.Tan(x) * Math.Tan(x) * b));
Console.WriteLine($"y={y:f2}");