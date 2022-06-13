using System.Diagnostics;

Console.SetBufferSize(400, 25000);
var words = File.ReadLines(@"..\..\..\..\Outputs\Words\words.txt");
Stopwatch stopwatchuniques = new Stopwatch();
Stopwatch stopwatchfullwords = new Stopwatch();

int uniquecounter = 0;
int fullwordscounter = 0;

Console.WriteLine("Unique Words \n");
stopwatchuniques.Start();
foreach (var word in words)
{

    if (word.Length == 4)
    {
        Console.WriteLine(word);
        uniquecounter++;
    }
}
stopwatchuniques.Stop();
Console.WriteLine("\nThere were {0} unique words.", uniquecounter);
Console.WriteLine("\nElapsed Time is {0} seconds.", stopwatchuniques.ElapsedMilliseconds / 1000.0);
Console.WriteLine("\nPress any key to continue.");
Console.ReadKey();
Console.Clear();


Console.WriteLine("Fullwords \n");
stopwatchfullwords.Start();
foreach (var word in words)
{

    if (word.Length >= 4)
    {
        Console.WriteLine(word);
        fullwordscounter++;
    }
}
Console.WriteLine("\nThere were {0} fullwords.", fullwordscounter);

Console.WriteLine("\nElapsed Time is {0} seconds.", stopwatchfullwords.ElapsedMilliseconds / 1000.0);
Console.WriteLine("\nPress any key to exit.");
Console.ReadKey();