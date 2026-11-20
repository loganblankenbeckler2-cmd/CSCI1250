// Step 2: the same report, now saved to two files.
const string LOG_FILE = "hours.txt";
const string REPORT_FILE = "report.txt";
const string HISTORY_FILE = "history.txt";

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

// The report is an array of lines, the same shape ReadAllLines handed us.
string[] report =
{
    "Total: " + total.ToString("F2") + " hours over " + lines.Length + " days",
    "Average: " + average.ToString("F2") + " hours a day",
    "Best day: Day " + bestDay + " with " + bestHours.ToString("F2") + " hours"
};

// foreach: printing needs every line and no position.
foreach (string reportLine in report)
{
    Console.WriteLine(reportLine);
}

File.WriteAllLines(REPORT_FILE, report);
File.AppendAllLines(HISTORY_FILE, report);
Console.WriteLine("Saved " + REPORT_FILE + " and added to " + HISTORY_FILE + ".");
