Console.WriteLine("Napiš číslo: ");
int num = Convert.ToInt32(Console.ReadLine());
check(num);

static void check(int num)
{
    if (num%2 == 0)
    {
        Console.WriteLine("Číslo je sudé");
    } else
    {
        Console.WriteLine("Číslo je liché");
    }
}