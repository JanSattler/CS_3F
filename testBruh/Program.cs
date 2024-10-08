for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Napiš číslo: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < 0)
    {
        Console.WriteLine("Číslo je záporné");
    } else
    {
        Console.WriteLine("Číslo je kladné");
    }
}