// The counter survives its first run: no file yet means the count is zero.
const string COUNT_FILE = "runs.txt";

int runs = 0;

try
{
    string[] lines = File.ReadAllLines(COUNT_FILE);
    runs = Convert.ToInt32(lines[0]);
}
catch (FileNotFoundException)
{
    Console.WriteLine("No count yet. Starting from zero.");
}

runs = runs + 1;
Console.WriteLine("This is run number " + runs + ".");

string[] output = { runs.ToString() };
File.WriteAllLines(COUNT_FILE, output);
