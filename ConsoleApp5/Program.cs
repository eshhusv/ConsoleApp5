Console.Write("Введите x1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите x2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Введите x3: ");
double x3 = double.Parse(Console.ReadLine());
Console.Write("Введите y3: ");
double y3 = double.Parse(Console.ReadLine());

Task<double> task1 = new Task<double>(() => GetA(x2, x1, y2, y1));
Task<double> task2 = task1.ContinueWith(task1 => GetB(x3, x1, y2, y3));
Task<double> task3 = task2.ContinueWith(task2 => GetC(x3, x1, y3, y1));
Task<double> task4 = task3.ContinueWith(task3 => GetP(task1.Result, task2.Result, task3.Result));
Task<double> task5 = task4.ContinueWith(task4 => GetS(task4.Result, task1.Result, task2.Result, task3.Result));

task1.Start();
task2.Wait();
task3.Wait();
task4.Wait();
task5.Wait();
Console.WriteLine(task5.Result);


double GetA(double x2, double x1, double y2, double y1)
{
    double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return a;
}
double GetB(double x3, double x2, double y3, double y2)
{
    double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
    return b;
}
double GetC(double x3, double x1, double y3, double y1)
{
    double c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y2, 2));
    return c;
}
double GetP(double a, double b, double c)
{
    return (a + b + c) / 2;
}
double GetS(double p, double a, double b, double c)
{
    double s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
    return s;
}