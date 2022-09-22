Console.Clear();

Console.Write("b1 = ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1 = ");
double k1 = int.Parse(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());

void IntersectionPoint ()
{
double x = Math.Round((b2-b1)/(k1-k2),1);
double y = Math.Round(k1 * x + b1,1);
Console.WriteLine($"Координаты точки пересечения прямых ({x};{y})");
}
IntersectionPoint();