/*
 * Name:        Mathew Desjardins
 * Course:      CSCI 1250
 * Assignment:  Lecture demo, Files and Exceptions
 * Date:        November 2026
 * Description: Reads a week of study hours from a file, reports the total,
 *              the average, and the best day, and saves the report. Keeps
 *              running when the file is missing or a line is not a number.
 */

const string LOG_FILE = "hours.txt";
const string REPORT_FILE = "report.txt";
const string HISTORY_FILE = "history.txt";

// Read the log. If it cannot be read, lines stays empty and the loop runs zero times.
string[] lines = { };

try
{
    lines = File.ReadAllLines(LOG_FILE);
}
catch (FileNotFoundException ex)
{
    Console.WriteLine("No study log yet.");
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("The study log could not be read.");
    Console.WriteLine(ex.Message);
}

double total = 0;
int daysCounted = 0;
double bestHours = 0;
int bestDay = 0;

// for: the day number is the index plus one, so the loop needs the index.
for (int i = 0; i < lines.Length; i++)
{
    // One bad line costs one day, not the whole week.
    try
    {
        double hours = Convert.ToDouble(lines[i]);
        total = total + hours;
        daysCounted = daysCounted + 1;

        if (hours > bestHours)
        {
            bestHours = hours;
            bestDay = i + 1;
        }

        Console.WriteLine("Day " + (i + 1) + ": " + hours.ToString("F2") + " hours");
    }
    catch (FormatException)
    {
        Console.WriteLine("Day " + (i + 1) + ": \"" + lines[i] + "\" is not a number, skipped");
    }
}

// Report only when at least one day was counted, so the average never divides by zero.
if (daysCounted > 0)
{
    double average = total / daysCounted;

    string[] report =
    {
        "Total: " + total.ToString("F2") + " hours over " + daysCounted + " days",
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
}
else
{
    Console.WriteLine("No hours to report.");
}
