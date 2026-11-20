// Step 1: read a week of study hours from a file and total them.
const string LOG_FILE = "hours.txt";

Console.WriteLine("Looking in: " + Directory.GetCurrentDirectory());

string[] lines = File.ReadAllLines(LOG_FILE);

double total = 0;
double bestHours = 0;
int bestDay = 0;

// for: the day number is the index plus one, so the loop needs the index.
for (int i = 0; i < lines.Length; i++)
{
    double hours = Convert.ToDouble(lines[i]);
    total = total + hours;

    if (hours > bestHours)
    {
        bestHours = hours;
        bestDay = i + 1;
    }

    Console.WriteLine("Day " + (i + 1) + ": " + hours.ToString("F2") + " hours");
}

double average = total / lines.Length;

Console.WriteLine("Total: " + total.ToString("F2") + " hours over " + lines.Length + " days");
Console.WriteLine("Average: " + average.ToString("F2") + " hours a day");
Console.WriteLine("Best day: Day " + bestDay + " with " + bestHours.ToString("F2") + " hours");
