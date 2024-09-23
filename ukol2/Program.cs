double[,] body = new double[4, 2];


for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Napiš x a pak y: ");
    body[i, 0] = Convert.ToDouble(Console.ReadLine());
    body[i, 1] = Convert.ToDouble(Console.ReadLine());
}


double obsah1 = (body[0,0] * body[1,1] + body[1,0] * body[2,1] + body[2,0] * body[3,1] + body[3,0] * body[0,1]);
double obsah2 = (body[0,1] * body[1,0] + body[1,1] * body[2,0] + body[2,1] * body[3,0] + body[3,1] * body[0,0]);

Console.WriteLine("obsah: "+0.5*Math.Abs(obsah1-obsah2));

double vzdalenost1 = Math.Sqrt(Math.Pow(body[1, 0] - body[0, 0], 2) + Math.Pow(body[1, 1] - body[0,1], 2));
double vzdalenost2 = Math.Sqrt(Math.Pow(body[2, 0] - body[1, 0], 2) + Math.Pow(body[2, 1] - body[1, 1], 2));
double vzdalenost3 = Math.Sqrt(Math.Pow(body[3, 0] - body[2, 0], 2) + Math.Pow(body[3, 1] - body[2, 1], 2));
double vzdalenost4 = Math.Sqrt(Math.Pow(body[0, 0] - body[3, 0], 2) + Math.Pow(body[0, 1] - body[3, 1], 2));

Console.WriteLine("obvod: "+(vzdalenost1+vzdalenost2+vzdalenost3+vzdalenost4));

