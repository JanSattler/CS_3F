using System.Drawing;

Point A = new Point();
Point B = new Point(); 


Console.Write("Zadej x pro A: ");
A.X = Int32.Parse(Console.ReadLine());
Console.Write("Zadej y pro A: ");
A.Y = Int32.Parse(Console.ReadLine());

Console.Write("Zadej x pro B: ");
B.X = Int32.Parse(Console.ReadLine());
Console.Write("Zadej y pro B: ");
B.Y = Int32.Parse(Console.ReadLine());



double distance = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
Console.WriteLine(distance);