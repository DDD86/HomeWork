Console.WriteLine("введите значение b1");
double b1 = Int32.Parse((Console.ReadLine()));
Console.WriteLine("введите число k1");
double k1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Int32.Parse(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Int32.Parse(Console.ReadLine());

double x;
double y;

x = (b2 - b1)/(k1 - k2);
y = k1 * x + b1;

Console.WriteLine($"Прямые пересекутся в точке с координатами X: {x}, Y: {y}");
