double[,] body = new double[4, 2];


//body[0, 0] = 1.0;
//body[0, 1] = 1.0;

//body[1, 0] = 4.0;
//body[1, 1] = 1.0;

//body[2, 0] = 4.0;
//body[2, 1] = 3.0;

//body[3, 0] = 1.0;
//body[3, 1] = 3.0;

for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Napiš x a pak y more: ");
    body[i, 0] = Convert.ToDouble(Console.ReadLine());
    body[i, 1] = Convert.ToDouble(Console.ReadLine());
}


for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"body[{body[i, 0]},{body[i, 1]}]");
}
    
