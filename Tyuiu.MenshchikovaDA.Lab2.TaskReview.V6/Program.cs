using Tyuiu.MenshchikovaDA.Lab2.Review.V6.Lib;

DataService ds = new DataService();
Console.Title = "Лабораторная работа #2 | Выполнил: Менщикова Д.А. | НТм-23-1 ";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Лабораторная работа #2                                                  *");
Console.WriteLine("* Тема: Табулирование функции по методологии TDD.                         *");
Console.WriteLine("* Вариант #6                                                              *");
Console.WriteLine("* Выполнил: Менщикова Дарья Андреевна | НТм-23-1                          *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая выводит таблицу значений функции f(x)       *");
Console.WriteLine("* на заданном диапазоне X1, X2. Произвести проверку деления на ноль.      *");
Console.WriteLine("* Значения должны храниться в массиве. Округлить значения до двух         *");
Console.WriteLine("* знаков после запятой.                                                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.Write("  Старт шага X1:   ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("  Конец шага X2:   ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
// Console.WriteLine(ds.Calc(x, y));
double[][] result = ds.GetMassFunction(x1, x2);

Console.WriteLine(new string('-', 23));
Console.WriteLine("|{0,10}|{1,10}|", "x", "f(x)");
Console.WriteLine(new string('-', 23));

foreach (double[] elem in result)
{
    Console.WriteLine("|{0,10}|{1,10}|", elem[0], elem[1]);
}

Console.WriteLine(new string('-', 23));

Console.ReadKey();