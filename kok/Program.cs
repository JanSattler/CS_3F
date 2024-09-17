double[,] body = new double[4,2];

body[0, 0] = 1.0;
body[0, 1] = 1.0;

body[1, 0] = 4.0;
body[1, 1] = 1.0;

body[2, 0] = 4.0;
body[2, 1] = 3.0;

body[3, 0] = 1.0;
body[3, 1] = 3.0;


for (int i = 0; i < body.Length; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.WriteLine(body[i, j]);
    }
}