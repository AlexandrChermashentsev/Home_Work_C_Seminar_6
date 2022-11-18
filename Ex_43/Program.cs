/*
Задача 43: Напишите программу которая найдет точку пересечения двух прямых 
заданных уравнениями y=k1*x+b1; y=k2*x+b2; 
значения b1, k1, b2, k2-задаются пользователем
b1=2, k1=5, b2=4, k2=9 -> (-0,5;-0,5)
*/

double GetNumbers(string msg)
{
    Console.WriteLine(msg);
    double message = Convert.ToInt32(Console.ReadLine());
    return message;
}

double b1 = GetNumbers("Enter b1");
double k1 = GetNumbers("Enter k1");
double b2 = GetNumbers("Enter b2");
double k2 = GetNumbers("Enter k2");
// k1*x+b1 = k2*x+b2
// x*(k1-k2) = b2-b1
// x = (b2-b1)/(k1-k2)
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Точка пересечения двух прямых: ({x}, {y})");
