int num = Convert.ToInt32(Console.ReadLine());
int vysledek =num;

for (int i = num -1; i > 0; i--)
{
    vysledek = vysledek * i;
}

Console.Write(vysledek);