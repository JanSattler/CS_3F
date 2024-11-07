Console.WriteLine("Napiš začátek promítání prvního filmu ve formátu hh:mm ");
DateTime movie1begin = DateTime.Parse(Console.ReadLine());

if (movie1begin.TimeOfDay < new TimeSpan(7, 0, 0))
{
    movie1begin = movie1begin.AddDays(1);
}

Console.WriteLine("Napiš délku prvního filmu ve formátu hh:mm ");
String[] movie1array = Console.ReadLine().Split(":");
TimeSpan movie1length = new TimeSpan(Int32.Parse(movie1array[0]), Int32.Parse(movie1array[1]), 0);
DateTime movie1end = movie1begin + movie1length;

Console.WriteLine("Napiš začátek promítání druhého filmu ve formátu hh:mm ");
DateTime movie2begin = DateTime.Parse(Console.ReadLine());

if (movie2begin.TimeOfDay < new TimeSpan(7, 0, 0))
{
    movie2begin = movie1begin.AddDays(1);
}

Console.WriteLine("Napiš délku druhého filmu ve formátu hh:mm ");
String[] movie2array = Console.ReadLine().Split(":");
TimeSpan movie2length = new TimeSpan(Int32.Parse(movie2array[0]), Int32.Parse(movie2array[1]), 0);
DateTime movie2end = movie2begin+ movie2length;



//Console.WriteLine(movie1begin.ToString("HH:mm"));
//Console.WriteLine(movie2length.ToString());
//Console.WriteLine(movie2end);

Console.WriteLine("Délka prvího filmu je "+movie1length.TotalMinutes + " minut");
Console.WriteLine("Délka druhého filmu je " + movie2length.TotalMinutes + " minut");

if (movie1end <= movie2begin)
{
    TimeSpan difference= movie2begin - movie1end;
    Console.WriteLine("Druhý film stihnete s předstihem " + difference.TotalMinutes + " minut");
} else
{
    if (movie1end > movie2begin)
    {
        Console.WriteLine("Druhý film nestihnete");
    } else
    {
        TimeSpan difference = movie1end - movie2begin;
        Console.WriteLine("Z druhého filmu nestihnete " + difference.TotalMinutes + " minut");
    }
    
}


