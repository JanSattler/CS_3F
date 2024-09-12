int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < num+1; i++)
{
    Console.Write("0");
    for (int j = 1; j < num+1; j++)
    {
        Console.Write("+"); 
    }
    Console.WriteLine();
}