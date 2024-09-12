/*static String MaTerezaSvátek(String input, String pass1, String pass2)
{

    if (input.Equals(pass1))
    {
        return pass2;
    }
    else
    {
        return "Pepa Nový je nula";
    }

}


String pass1 = "Ahoj";
String pass2 = "Čau";
String input = Console.ReadLine();

Console.WriteLine(MaTerezaSvátek(input, pass1, pass2));*/


void Method(int num)
{
    for (int i = 0; i <= num; i++) { 
        for (int j = 0; j < i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Napiš číslo");
int num = Convert.ToInt32(Console.ReadLine());
Method(num);

